namespace Apache.ApplicationDbContexMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Apache.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Web.Mvc;


    internal sealed class Configuration : DbMigrationsConfiguration<Apache.Models.ApplicationDbContext>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public Configuration()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())), new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(new ApplicationDbContext())))
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ApplicationDbContexMigration";
        }

        public Configuration(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;

        }
        public UserManager<ApplicationUser> UserManager { get; private set; }

        public RoleManager<ApplicationRole> RoleManager { get; private set; }

        protected override void Seed(Apache.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            #region         ������֯������Ŀ¼���ֵ��Ŀ¼
            var Organizations = new List<Organization>                    //��ʼ����֯����

            {
                new Organization {orgName = "������֯����ȫ��",orgShortName="������֯�������",orgCode="",orgType="����֯",orgNote=""}
            };
            Organizations.ForEach(s => context.Organizations.AddOrUpdate(p => p.orgName, s));
            context.SaveChanges();

            var DataDicts = new List<DataDict>                    //��ʼ�������ֵ�

            {
                new DataDict {DataDictName = "���ֵ�", DataDictCode="",DataDictType="�������ֵ�",DataDictNote=""}
            };
            DataDicts.ForEach(s => context.DataDicts.AddOrUpdate(p => p.DataDictName, s));
            context.SaveChanges();

            var rootDictList = db.DataDicts.Where(i => i.DataDictName == "���ֵ�").FirstOrDefault(); //�ڸ��ֵ������ӷ�������ֵ� 
            if (rootDictList != null)                                                                  
            {
                var catalogDict = new List<DataDict>
                {
				   new DataDict {DataDictName = "IT�������", DataDictCode="",DataDictType="",DataDictNote="",parentId=rootDictList.ID}
			    };
                catalogDict.ForEach(s => context.DataDicts.AddOrUpdate(p => p.DataDictName, s));
                context.SaveChanges();
            }

            #endregion

            #region         ���ӹ���Ա�˺�
            if (UserManager.FindByName("admin") == null)       //��ʼ��admin
            {
                var org = db.Organizations.Where(i => i.orgType == "����֯").FirstOrDefault();
                if (org != null)
                {
                    var user = new ApplicationUser() { UserName = "admin" };
                    user.TrueName = "����Ա";
                    user.Order = 1000;
                    user.OrganizationID = org.ID;
                    var result = UserManager.Create(user, "admin888");
                }
            }
            #endregion

            #region         ����Ŀ¼--���˵�--������
            var rootMenu = new List<Menu>                                            //���Ӹ�ģ��

            {
                new Menu {menuName = "��ģ��", menuType="��ģ��",menuOrder=0,parentId=0,isSysMenu="1"}
            };
            rootMenu.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
            context.SaveChanges();
            var rootMenuList = db.Menus.Where(i => i.menuName == "��ģ��").FirstOrDefault();
            if (rootMenuList != null)                                                            //����ϵͳ����Ŀ¼ģ��       
            {
                var catalogMenus = new List<Menu>
                {
				   new Menu {menuName = "ϵͳ����", menuType="ģ��Ŀ¼",menuOrder=1,isMenu="��",menuIcon="icon-sys-manage",parentId=rootMenuList.ID,isSysMenu="1"}
			    };
                catalogMenus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }


            var catalogMenuList = db.Menus.Where(i => i.menuName == "ϵͳ����").FirstOrDefault();
            if (catalogMenuList != null)                                                            //����ϵͳ����ģ��       
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "��֯��������", menuType="ģ��",menuController="Organization",menuAction="Index",menuOrder=10000,menuIcon="icon-sys-organization",parentId=catalogMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�û�����", menuType="ģ��",menuController="Account",menuAction="Users",menuOrder=9000,menuIcon="icon-sys-user",parentId=catalogMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ģ�����", menuType="ģ��",menuController="Menu",menuAction="Index",menuOrder=8000,menuIcon="icon-sys-model",parentId=catalogMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ɫ����", menuType="ģ��",menuController="Account",menuAction="Roles",menuOrder=7000,menuIcon="icon-sys-role",parentId=catalogMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��־����", menuType="ģ��",menuController="Logging",menuAction="Index",menuOrder=6000,menuIcon="icon-sys-log",parentId=catalogMenuList.ID,isSysMenu="1"}, 
                   new Menu {menuName = "�����ֵ����", menuType="ģ��",menuController="DataDict",menuAction="Index",menuOrder=5000,menuIcon="icon-sys-datadict",parentId=catalogMenuList.ID,isSysMenu="1"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var orgMenuList = db.Menus.Where(i => i.menuName == "��֯��������").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (orgMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "�����֯����", menuType="����",menuController="Organization",menuAction="CreateOrg",menuOrder=1000,menuIcon="",parentId=orgMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�޸���֯����", menuType="����",menuController="Organization",menuAction="EditOrg",menuOrder=1000,menuIcon="",parentId=orgMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ɾ����֯����", menuType="����",menuController="Organization",menuAction="DelOrg",menuOrder=1000,menuIcon="",parentId=orgMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ��֯�����б�", menuType="����",menuController="Organization",menuAction="orgList",menuOrder=1000,menuIcon="",parentId=orgMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }


            var datadictMenuList = db.Menus.Where(i => i.menuName == "�����ֵ����").FirstOrDefault();                   //���������ֵ����ϵͳ����ģ��   
            if (datadictMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "��������ֵ�", menuType="����",menuController="DataDict",menuAction="CreateDataDict",menuOrder=1000,menuIcon="",parentId=datadictMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�޸������ֵ�", menuType="����",menuController="DataDict",menuAction="EditDataDict",menuOrder=1000,menuIcon="",parentId=datadictMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ɾ�������ֵ�", menuType="����",menuController="DataDict",menuAction="DelDataDict",menuOrder=1000,menuIcon="",parentId=datadictMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ�����ֵ��б�", menuType="����",menuController="DataDict",menuAction="DataDictList",menuOrder=1000,menuIcon="",parentId=datadictMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }



            var userMenuList = db.Menus.Where(i => i.menuName == "�û�����").FirstOrDefault();                   //�����û�����ϵͳ����ģ��   
            if (userMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "����û�", menuType="����",menuController="Account",menuAction="Register",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�޸��û�", menuType="����",menuController="Account",menuAction="EditUser",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ɾ���û�", menuType="����",menuController="Account",menuAction="DelUser",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�����û�����", menuType="����",menuController="Account",menuAction="ResetPassword",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ��Ա�б�", menuType="����",menuController="Account",menuAction="UserList",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�����ʾ��֯�����б�", menuType="����",menuController="Account",menuAction="orgTree",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�����û���ɫ", menuType="����",menuController="Account",menuAction="UsersOfRole",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ���н�ɫ�б�", menuType="����",menuController="Account",menuAction="RoleList",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ�û�ӵ�еĽ�ɫ�б�", menuType="����",menuController="Account",menuAction="UserRoleList",menuOrder=1000,menuIcon="",parentId=userMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var memuMenuList = db.Menus.Where(i => i.menuName == "ģ�����").FirstOrDefault();                   //����ģ�����ϵͳ����ģ��   
            if (memuMenuList != null)
            {
                var Menus = new List<Menu>
                {
                   new Menu {menuName = "���ģ��", menuType="����",menuController="Menu",menuAction="CreateMenu",menuOrder=1000,menuIcon="",parentId=memuMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�޸�ģ��", menuType="����",menuController="Menu",menuAction="EditMenu",menuOrder=1000,menuIcon="",parentId=memuMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ɾ��ģ��", menuType="����",menuController="Menu",menuAction="DelMenu",menuOrder=1000,menuIcon="",parentId=memuMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾģ���б�", menuType="����",menuController="Menu",menuAction="menuList",menuOrder=1000,menuIcon="",parentId=memuMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var roleMenuList = db.Menus.Where(i => i.menuName == "��ɫ����").FirstOrDefault();                   //����ģ�����ϵͳ����ģ��   
            if (roleMenuList != null)
            {
                var Menus = new List<Menu>
                {
                   new Menu {menuName = "��ӽ�ɫ", menuType="����",menuController="Account",menuAction="CreateRole",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�޸Ľ�ɫ", menuType="����",menuController="Account",menuAction="EditRole",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "ɾ����ɫ", menuType="����",menuController="Account",menuAction="DelRole",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ��ɫ�б�", menuType="����",menuController="Account",menuAction="RoleList",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾϵͳ��֯����", menuType="����",menuController="Account",menuAction="orgTree",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾϵͳ�����û�", menuType="����",menuController="Account",menuAction="UserListForRoleManage",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ��ɫӵ�е��û�", menuType="����",menuController="Account",menuAction="RoleUserList",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾϵͳ�����й���ģ��", menuType="����",menuController="Account",menuAction="menuTree",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "��ʾ��ɫӵ�еĹ���ģ��", menuType="����",menuController="Account",menuAction="MenuToRoleList",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "�����û�����ɫ", menuType="����",menuController="Account",menuAction="UsersToRole",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"},
                   new Menu {menuName = "����ģ�鵽��ɫ", menuType="����",menuController="Account",menuAction="MenusToRole",menuOrder=1000,menuIcon="",parentId=roleMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }


            var logMenuList = db.Menus.Where(i => i.menuName == "��־����").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (orgMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "�鿴��־�б�", menuType="����",menuController="Logging",menuAction="LogList",menuOrder=1000,menuIcon="",parentId=logMenuList.ID,isSysMenu="1"}

			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }
            #endregion

            #region         ����ҵ��Ŀ¼--��ҵ��˵�--��ҵ���ܣ��˴�ΪIT������� (ע��������ҵ����ģ��󣬿��ڴ˳�ʼ�����ݿ⣬Ҳ������ϵͳ�����е�ģ������н�������)
            var bRootMenuList = db.Menus.Where(i => i.menuName == "��ģ��").FirstOrDefault();
            if (bRootMenuList != null)                                                            //����IT����Ŀ¼ģ��       
            {
                var catalogMenus = new List<Menu>
                {
				   new Menu {menuName = "IT����", menuType="ģ��Ŀ¼",menuOrder=9,isMenu="��",menuIcon="icon-it-services",parentId=bRootMenuList.ID,isSysMenu="0"}
			    };
                catalogMenus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }


            var bCatalogMenuList = db.Menus.Where(i => i.menuName == "IT����").FirstOrDefault();
            if (bCatalogMenuList != null)                                                            //����IT����˵�ģ��       
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "�������", menuType="ģ��",menuController="ItService",menuAction="Create",menuOrder=10000,menuIcon="icon-it-create",parentId=bCatalogMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "�ҵ�����", menuType="ģ��",menuController="ItService",menuAction="MyWorkFlow",menuOrder=9000,menuIcon="icon-it-services-list",parentId=bCatalogMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "�������", menuType="ģ��",menuController="ItService",menuAction="WorkFlowManage",menuOrder=8000,menuIcon="icon_wf_manage",parentId=bCatalogMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "ͳ�Ʒ���", menuType="ģ��",menuController="ItService",menuAction="Statistic",menuOrder=7000,menuIcon="icon_isi_chart",parentId=bCatalogMenuList.ID,isSysMenu="0"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var bCreateWfMenuList = db.Menus.Where(i => i.menuName == "�������").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (bCreateWfMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "����ߴ�������", menuType="����",menuController="ItService",menuAction="CreateWorkFlow",menuOrder=1000,menuIcon="",parentId=bCreateWfMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "������ύ��һ����", menuType="����",menuController="ItService",menuAction="DrafterToNextState",menuOrder=1000,menuIcon="",parentId=bCreateWfMenuList.ID,isSysMenu="0"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var bMyWfMenuList = db.Menus.Where(i => i.menuName == "�ҵ�����").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (bMyWfMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "�û����뵥�б�", menuType="����",menuController="ItService",menuAction="MyWorkFlowList",menuOrder=1000,menuIcon="",parentId=bMyWfMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "�û��鿴�Լ������뵥", menuType="����",menuController="ItService",menuAction="ViewWorkFlow",menuOrder=1000,menuIcon="",parentId=bMyWfMenuList.ID,isSysMenu="0"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var bManageWfMenuList = db.Menus.Where(i => i.menuName == "�������").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (bManageWfMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "��ʾ���е������б�", menuType="����",menuController="ItService",menuAction="AllWorkFlowList",menuOrder=1000,menuIcon="",parentId=bManageWfMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "�鿴���뵥��ϸ��Ϣ", menuType="����",menuController="ItService",menuAction="ViewWorkFlow",menuOrder=1000,menuIcon="",parentId=bManageWfMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "ɾ�����뼰ҵ������", menuType="����",menuController="ItService",menuAction="DelWorkFlow",menuOrder=1000,menuIcon="",parentId=bManageWfMenuList.ID,isSysMenu="0"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            var bStatisticMenuList = db.Menus.Where(i => i.menuName == "ͳ�Ʒ���").FirstOrDefault();                   //������֯��������ϵͳ����ģ��   
            if (bStatisticMenuList != null)
            {
                var Menus = new List<Menu>
                {
				   new Menu {menuName = "��ʾͳ�Ʒ����б�", menuType="����",menuController="ItService",menuAction="ItServiceList",menuOrder=1000,menuIcon="",parentId=bStatisticMenuList.ID,isSysMenu="0"},
                   new Menu {menuName = "����ͳ�Ʒ���xls", menuType="����",menuController="ItService",menuAction="IsiExportXls",menuOrder=1000,menuIcon="",parentId=bStatisticMenuList.ID,isSysMenu="0"}
			    };
                Menus.ForEach(s => context.Menus.AddOrUpdate(p => p.menuName, s));
                context.SaveChanges();
            }

            #endregion
        }
    }
}
