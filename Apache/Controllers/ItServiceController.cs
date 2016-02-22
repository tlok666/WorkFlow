﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Threading;
using System.Configuration;
using System.Runtime.DurableInstancing;
using Microsoft.Activities.Extensions;
using Microsoft.Activities.Extensions.Tracking;
using System.Xaml;
using System.Reflection;
using System.Activities.XamlIntegration;
using Apache.WorkFlow;
using Apache.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Activities.Tracking;
using Newtonsoft.Json.Linq;
using Apache.Filters;
using System.Globalization;
using System.Data;
using Apache.Helper;


namespace Apache.Controllers
{
    [Authorize]
    [Logging]
    public class ItServiceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private BusinessDataContext bdb = new BusinessDataContext();
        //
        // GET: /ItService/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyWorkFlow()
        {
            return View();
        }

        public ActionResult WorkFlowManage()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Statistic()
        {
            return View();
        }
        public ActionResult GuaredFamily()
        {
            //GuaredDb.sName = "户主姓名";
            //GuaredDb.sIdentityNum = "000000000000000000";
            //GuaredDb.bSex = false;
            //GuaredDb.sRace = "汉族";
            //GuaredDb.sFamilyAddress = "四川省广元市剑阁县龙源镇";
            ////GuaredDb.sBirthMonth = "1988-08-08";
            //GuaredDb.iPopulation = 3;
            //GuaredDb.bIsDisable = false;
            //GuaredDb.fMember = new List<Apache.Models.GuaredFamilyItem.FamilyMember>();
            //GuaredDb.fMember = GuaredDb.GetFamilyMember();
            //return View("GuaredFamily",GuaredDb);
            return View();
        }
        public ActionResult LeavingCadre()
        {
            return View();
        }
        public ActionResult OldParty()
        {
            return View();
        }
        public ActionResult MedicalAid()
        {
            return View();
        }
        public ActionResult DifficultyPeople()
        {
            return View();
        }
        public ActionResult SubmitSuccess()
        {
            return View();
        }
        [ApachAuthentication]
        public JObject CreateWorkFlow()   //起草者创建流程，并保存到微软持续化数据库中
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.Id == currentUserId);    //获取当前用户username
            WorkFlowInParameter WfInData = new WorkFlowInParameter();
            WfInData.drafter = user.UserName;
            Dictionary<string, object> inputs = new Dictionary<string, object>();
            inputs.Add("WfIn", WfInData);
            var act = CreateActivityFrom(Server.MapPath("~") + "\\WorkFlow\\ItService.xaml");
            WorkflowApplication wfApp = new WorkflowApplication(new ItService(), inputs)
            {

                InstanceStore = CreateInstanceStore(),
                PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                    //var ex = e.GetInstanceExtensions<CustomTrackingParticipant>();
                    //Outputs = ex.First().Outputs.ToString();
                    return PersistableIdleAction.Unload;
                },
                Completed = delegate(WorkflowApplicationCompletedEventArgs e)
                {

                },
                Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
                {
                },
                Unloaded = delegate(WorkflowApplicationEventArgs e)
                {
                    syncEvent.Set();
                },
                OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
                {
                    return UnhandledExceptionAction.Terminate;
                },
                Idle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                }

            };
            var StateTracker = new StateMachineStateTracker(wfApp.WorkflowDefinition); //当前状态追踪
            wfApp.Extensions.Add(StateTracker);
            wfApp.Extensions.Add(new StateTrackerPersistenceProvider(StateTracker));
            var cu = new CustomTrackingParticipant();           //获取Activity内部变量
            wfApp.Extensions.Add(cu);                         //获取Activity内部变量需要的追踪器
            Guid instanceId = wfApp.Id;
            //var trackerInstance = StateMachineStateTracker.LoadInstance(id, wfApp.WorkflowDefinition, ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            wfApp.Run();
            syncEvent.WaitOne();
            //string CurrentUser = cu.Outputs["CurrentUser"].ToString();
            var Pt = StateTracker.PossibleTransitions;
            //var CurrentState = StateTracker.CurrentState;

            //BookmarkResumptionResult result = wfApp.ResumeBookmark("Hello123", "ddd");
            string[] strs = Pt.Split(',');



            JObject json = new JObject(
                new JProperty("instanceId", instanceId),
                new JProperty("rows",
                new JArray(
                     from r in strs
                     select new JObject(
           new JProperty("ID", r.ToString()),
           new JProperty("Name", r.ToString())))));



            return json;
        }

        [ApachAuthentication]
        public ActionResult DrafterToNextState(ItServiceItem isi, Guid instanceId, string NextLink)  //起草者到下一环节
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);

            WorkflowApplication wfApp = new WorkflowApplication(new ItService())
            {

                InstanceStore = CreateInstanceStore(),
                PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                    //var ex = e.GetInstanceExtensions<CustomTrackingParticipant>();
                    // Outputs = ex.First().Outputs.ToString();
                    return PersistableIdleAction.Unload;
                },
                Completed = delegate(WorkflowApplicationCompletedEventArgs e)
                {

                },
                Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
                {
                },
                Unloaded = delegate(WorkflowApplicationEventArgs e)
                {
                    syncEvent.Set();
                },
                OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
                {
                    return UnhandledExceptionAction.Terminate;
                },
                Idle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                }

            };
            var StateTracker = new StateMachineStateTracker(wfApp.WorkflowDefinition); //当前状态追踪
            wfApp.Extensions.Add(StateTracker);
            wfApp.Extensions.Add(new StateTrackerPersistenceProvider(StateTracker));
            var cu = new CustomTrackingParticipant();           //获取Activity内部变量
            wfApp.Extensions.Add(cu);                         //获取Activity内部变量需要的追踪器
            //Guid instanceId = wfApp.Id;
            var trackerInstance = StateMachineStateTracker.LoadInstance(instanceId, wfApp.WorkflowDefinition, ConfigurationManager.ConnectionStrings["ApacheConnection"].ConnectionString);
            wfApp.Load(instanceId);
            BookmarkResumptionResult result = wfApp.ResumeBookmark(trackerInstance.CurrentState, NextLink.Trim());
            syncEvent.WaitOne();
            string CurrentUser = cu.Outputs["CurrentUser"].ToString();
            string OpinionField = cu.Outputs["OpinionField"].ToString();
            string Drafter = cu.Outputs["Drafter"].ToString();
            var CurrentState = StateTracker.CurrentState;
            //var Pt = StateTracker.PossibleTransitions;
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.UserName == Drafter);    //获取当前用户username
            isi.drafter = Drafter;
            isi.isiCreateDate = DateTime.Now;
            bdb.ItServiceItems.Add(isi);      //添加业务数据
            try
            {
                bdb.SaveChanges();
            }
            catch
            {
                var json = new
                {
                    errorMsg = "添加业务数据出错"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
            WorkFlowItem wf = new WorkFlowItem();
            wf.WfInstanceId = instanceId;
            wf.WfType = "测试申请表";
            wf.WfCurrentUser = CurrentUser;
            wf.WfDrafter = Drafter;
            wf.WfWriteField = OpinionField;
            wf.Wfstatus = CurrentState;
            wf.WfBussinessUrl = "/ItService/OpenWorkFlow?id=" + instanceId;
            wf.WfCreateDate = DateTime.Now;
            wf.WfBusinessId = isi.ID; //添加业务数据关联
            wf.WfFlowChart = trackerInstance.CurrentState + "(" + user.TrueName + ")";
            bdb.WorkFlowItems.Add(wf);
            bdb.SaveChanges();
            try
            {
                bdb.SaveChanges();
                var json = new
                {
                    okMsg = "流程保存成功"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
            catch
            {
                var json = new
                {
                    errorMsg = "流程保存出错"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult GuaredFamilyToNextState(GuaredFamilyItem isi, Guid instanceId, string NextLink)  //起草者到下一环节
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);

            WorkflowApplication wfApp = new WorkflowApplication(new ItService())
            {

                InstanceStore = CreateInstanceStore(),
                PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                    //var ex = e.GetInstanceExtensions<CustomTrackingParticipant>();
                    // Outputs = ex.First().Outputs.ToString();
                    return PersistableIdleAction.Unload;
                },
                Completed = delegate(WorkflowApplicationCompletedEventArgs e)
                {

                },
                Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
                {
                },
                Unloaded = delegate(WorkflowApplicationEventArgs e)
                {
                    syncEvent.Set();
                },
                OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
                {
                    return UnhandledExceptionAction.Terminate;
                },
                Idle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                }

            };
            var StateTracker = new StateMachineStateTracker(wfApp.WorkflowDefinition); //当前状态追踪
            wfApp.Extensions.Add(StateTracker);
            wfApp.Extensions.Add(new StateTrackerPersistenceProvider(StateTracker));
            var cu = new CustomTrackingParticipant();           //获取Activity内部变量
            wfApp.Extensions.Add(cu);                         //获取Activity内部变量需要的追踪器
            //Guid instanceId = wfApp.Id;
            var trackerInstance = StateMachineStateTracker.LoadInstance(instanceId, wfApp.WorkflowDefinition, ConfigurationManager.ConnectionStrings["ApacheConnection"].ConnectionString);
            wfApp.Load(instanceId);
            BookmarkResumptionResult result = wfApp.ResumeBookmark(trackerInstance.CurrentState, NextLink.Trim());
            syncEvent.WaitOne();
            string CurrentUser = cu.Outputs["CurrentUser"].ToString();
            string OpinionField = cu.Outputs["OpinionField"].ToString();
            string Drafter = cu.Outputs["Drafter"].ToString();
            var CurrentState = StateTracker.CurrentState;
            //var Pt = StateTracker.PossibleTransitions;
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.UserName == Drafter);    //获取当前用户username
            isi.drafter = Drafter;
            isi.isiCreateDate = DateTime.Now;
            ItServiceItem Ititem = new ItServiceItem();
            Ititem.Title = "剑阁县龙源镇农村五保对象供养审批表";
            Ititem.applicant = "";
            bdb.GuaredFamilyItems.Add(isi);      //添加业务数据
            bdb.ItServiceItems.Add(Ititem);
            //try
            //{
                bdb.SaveChanges();
            //}
            //catch
            //{
            //    var json = new
            //    {
            //        errorMsg = "添加业务数据出错"
            //    };

            //    return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            //}
            WorkFlowItem wf = new WorkFlowItem();
            wf.WfInstanceId = instanceId;
            wf.WfType = "五保户申请表";
            wf.WfCurrentUser = CurrentUser;
            wf.WfDrafter = Drafter;
            wf.WfWriteField = OpinionField;
            wf.Wfstatus = CurrentState;
            wf.WfBussinessUrl = "/ItService/OpenWorkFlow?id=" + instanceId;
            wf.WfCreateDate = DateTime.Now;
            wf.WfBusinessId = isi.ID; //添加业务数据关联
            wf.WfFlowChart = trackerInstance.CurrentState + "(" + user.TrueName + ")";
            bdb.WorkFlowItems.Add(wf);
            bdb.SaveChanges();
            try
            {
                bdb.SaveChanges();
                var json = new
                {
                    okMsg = "流程保存成功"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
            catch
            {
                var json = new
                {
                    errorMsg = "流程保存出错"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
        }
        public JObject GetPossiblePath(Guid id)                     //审批用户获取下一步可能的路径
        {
            WorkflowApplication wfApp = new WorkflowApplication(new ItService())
            {

                InstanceStore = CreateInstanceStore(),
                PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                    //var ex = e.GetInstanceExtensions<CustomTrackingParticipant>();
                    // Outputs = ex.First().Outputs.ToString();
                    return PersistableIdleAction.Unload;
                },
                Completed = delegate(WorkflowApplicationCompletedEventArgs e)
                {

                },
                Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
                {
                },
                Unloaded = delegate(WorkflowApplicationEventArgs e)
                {
                },
                OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
                {
                    return UnhandledExceptionAction.Terminate;
                },
                Idle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                }

            };
            var trackerInstance = StateMachineStateTracker.LoadInstance(id, wfApp.WorkflowDefinition, ConfigurationManager.ConnectionStrings["ApacheConnection"].ConnectionString);

            var Pt = trackerInstance.PossibleTransitions;

            //BookmarkResumptionResult result = wfApp.ResumeBookmark("Hello123", "ddd");
            string[] strs = Pt.Split(',');
            JObject json = new JObject(
                new JProperty("rows",
                new JArray(
                     from r in strs
                     select new JObject(
           new JProperty("ID", r.ToString()),
           new JProperty("Name", r.ToString())))));



            return json;

        }


        public ActionResult ToNextState(ItServiceItem isi, Guid instanceId, string NextLink, string Opinion)  //审批者到下一环节,思路：保存当前流程的数据，恢复bookmark到下一环节，并保存下一环节流程信息
        {
            #region 判断是不是当前处理人
            WorkFlowItem cwfi = bdb.WorkFlowItems.Where(i => i.WfInstanceId == instanceId).FirstOrDefault();
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.Id == currentUserId);
            if (cwfi.WfCurrentUser.ToString().Trim() != user.UserName.ToString().Trim())
            {
                var json = new
                {
                    errorMsg = "你不是当前处理人"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
            #endregion
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            int isComplete = 0;
            WorkflowApplication wfApp = new WorkflowApplication(new ItService())
            {

                InstanceStore = CreateInstanceStore(),
                PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                    //var ex = e.GetInstanceExtensions<CustomTrackingParticipant>();
                    // Outputs = ex.First().Outputs.ToString();
                    return PersistableIdleAction.Unload;
                },
                Completed = delegate(WorkflowApplicationCompletedEventArgs e)
                {
                    isComplete = 1;
                    syncEvent.Set();
                },
                Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
                {
                },
                Unloaded = delegate(WorkflowApplicationEventArgs e)
                {
                    syncEvent.Set();
                },
                OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
                {
                    return UnhandledExceptionAction.Terminate;
                },
                Idle = delegate(WorkflowApplicationIdleEventArgs e)
                {
                }

            };
            var StateTracker = new StateMachineStateTracker(wfApp.WorkflowDefinition); //当前状态追踪
            wfApp.Extensions.Add(StateTracker);
            wfApp.Extensions.Add(new StateTrackerPersistenceProvider(StateTracker));
            var cu = new CustomTrackingParticipant();           //获取Activity内部变量
            wfApp.Extensions.Add(cu);                         //获取Activity内部变量需要的追踪器
            //Guid instanceId = wfApp.Id;
            var trackerInstance = StateMachineStateTracker.LoadInstance(instanceId, wfApp.WorkflowDefinition, ConfigurationManager.ConnectionStrings["ApacheConnection"].ConnectionString);
            wfApp.Load(instanceId);

            BookmarkResumptionResult result = wfApp.ResumeBookmark(trackerInstance.CurrentState, NextLink.Trim());   //恢复当前状态,并进入下一个bookmark,注意使用Trim,开始没使用，NextLInk无法取到，调试了大半夜
            syncEvent.WaitOne();

            string CurrentUser;
            string OpinionField = "";
            string CurrentState;
            string completeStr = "";

            if (isComplete == 0)
            {
                CurrentUser = cu.Outputs["CurrentUser"].ToString();
                OpinionField = cu.Outputs["OpinionField"].ToString();
                CurrentState = StateTracker.CurrentState;
            }
            else
            {
                CurrentUser = "System";
                CurrentState = "已结束";
                completeStr = "->结束";
            }
            //string currentUserId = User.Identity.GetUserId();
            //ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.Id == currentUserId);    //获取当前用户TrueName，为增加流转信息提供数据
            WorkFlowItem wfi = bdb.WorkFlowItems.Where(i => i.WfInstanceId == instanceId).FirstOrDefault();     //获取当前流程信息
            ItServiceItem cisi = bdb.ItServiceItems.Where(i => i.ID == isi.ID).FirstOrDefault();                //获取当前业务数据的信息

            #region 业务数据更新开始
            cisi.Title = isi.Title;
            cisi.applicant = isi.applicant;
            cisi.applicant_dept = isi.applicant_dept;
            cisi.applicantPhone = isi.applicantPhone;
            cisi.description = isi.description;
            cisi.solution = isi.solution;
            cisi.isitype = isi.isitype;
            cisi.sub_isitype = isi.sub_isitype;
            cisi.end_isitype = isi.end_isitype;
            if (isComplete == 1)
                cisi.isiCompleteDate = DateTime.Now;
            #endregion

            #region 审批意见更新开始
            if (Opinion != null)
            {
                if (Convert.ToString(Opinion) != "")
                {
                    if (wfi.WfWriteField.Trim() == "ItManagerOpinion")
                    {
                        cisi.ItManagerOpinion = cisi.ItManagerOpinion + "<br>" + Opinion + "     (意见填写人:" + user.TrueName + "    时间:" + DateTime.Now + ")";
                    }
                    if (wfi.WfWriteField.Trim() == "ProcessingDepartmentOpinion")
                    {
                        cisi.ProcessingDepartmentOpinion = cisi.ProcessingDepartmentOpinion + "<br>" + Opinion + "     (意见填写人:" + user.TrueName + "    时间:" + DateTime.Now + ")";
                    }

                }
            }
            #endregion


            if (wfi != null)
            {
                wfi.WfCurrentUser = CurrentUser;
                wfi.Wfstatus = CurrentState;
                wfi.WfWriteField = OpinionField;
                if (isComplete == 1)
                    wfi.WfCompleteDate = DateTime.Now;
                wfi.WfFlowChart = wfi.WfFlowChart + "->" + trackerInstance.CurrentState + "(" + user.TrueName + ")" + completeStr;          //增加流转信息
                try
                {
                    bdb.SaveChanges();
                    var json = new
                    {
                        okMsg = "提交成功"
                    };

                    return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    var json = new
                    {
                        errorMsg = "提交失败"
                    };

                    return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                var json = new
                {
                    errorMsg = "流程不存在"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult OpenWorkFlow(Guid id)         //用户处理流程
        {
            #region 判断是不是当前处理人
            WorkFlowItem cwfi = bdb.WorkFlowItems.Where(i => i.WfInstanceId == id).FirstOrDefault();
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.Id == currentUserId);
            if (cwfi.WfCurrentUser.ToString().Trim() != user.UserName.ToString().Trim())
            {
                var json = new
                {
                    errorMsg = "你不是当前处理人"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }
            #endregion
            var wf = bdb.WorkFlowItems.Where(i => i.WfInstanceId == id).FirstOrDefault();
            var bid = wf.WfBusinessId;
            ViewBag.WfWriteField = wf.WfWriteField;
            ViewBag.WfFlowChart = wf.WfFlowChart;
            ViewBag.instanceId = wf.WfInstanceId;
            ItServiceItem isi = bdb.ItServiceItems.Where(i => i.ID == bid).FirstOrDefault();
            return View(isi);
        }
        [ApachAuthentication]
        public ActionResult ViewWorkFlow(Guid id)           //用户查看自己的流程
        {
            var wf = bdb.WorkFlowItems.Where(i => i.WfInstanceId == id).FirstOrDefault();
            var bid = wf.WfBusinessId;
            ViewBag.WfWriteField = wf.WfWriteField;
            ViewBag.WfFlowChart = wf.WfFlowChart;
            ViewBag.instanceId = wf.WfInstanceId;
            ItServiceItem isi = bdb.ItServiceItems.Where(i => i.ID == bid).FirstOrDefault();
            return View(isi);
        }
        [ApachAuthentication]
        public JObject MyWorkFlowList(int? page, int? rows)        //用户流程列表
        {
            string username = HttpContext.Session["UserName"].ToString().Trim();
            List<WorkFlowItem> list = bdb.WorkFlowItems.Where(i => i.WfDrafter == username).OrderByDescending(c => c.WfCreateDate).Skip((Convert.ToInt32(page) - 1) * Convert.ToInt32(rows)).Take(Convert.ToInt32(rows)).ToList(); ;
            JObject json = new JObject(
                new JProperty("total", bdb.WorkFlowItems.ToList().Count()),
                new JProperty("rows",
                    new JArray(
                        from r in list
                        select new JObject(
                            new JProperty("ID", r.ID),
                            new JProperty("WfInstanceId", r.WfInstanceId),
                            new JProperty("WfType", r.WfType),
                            new JProperty("WfBussinessUrl", r.WfBussinessUrl),
                            new JProperty("WfTitle", GetWfName(r.WfBusinessId)),
                            new JProperty("WfCurrentUser", r.WfCurrentUser),
                            new JProperty("Wfstatus", r.Wfstatus),
                            new JProperty("WfDrafter", GetWfDrafterName(r.WfDrafter)),
                            new JProperty("WfApplicant", GetWfApplicantName(r.WfBusinessId)),
                            new JProperty("WfCreateDate", r.WfCreateDate)))));



            return json;
        }
        [ApachAuthentication]
        public ActionResult DelWorkFlow(Guid id)          //删除流程及业务数据
        {
            if (id != null)
            {
                WorkFlowItem wf = bdb.WorkFlowItems.Where(i => i.WfInstanceId == id).FirstOrDefault();
                var bid = wf.WfBusinessId;
                ItServiceItem isi = bdb.ItServiceItems.Where(i => i.ID == bid).FirstOrDefault();

                if (wf != null && isi != null)
                {
                    if (wf.Wfstatus != "已结束")
                    {
                        bdb.WorkFlowItems.Remove(wf);
                        bdb.ItServiceItems.Remove(isi);
                        try
                        {
                            bdb.SaveChanges();
                            var json = new
                            {
                                okMsg = "删除成功"
                            };

                            return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                        }
                        catch
                        {
                            var json = new
                            {
                                errorMsg = "由于数据库或系统原因，删除流程失败"
                            };

                            return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                        }
                    }
                    else
                    {
                        var json = new
                        {
                            okMsg = "已结束流程不能删除"
                        };

                        return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    var json = new
                    {
                        okMsg = "未找到相关流程和业务数据"
                    };

                    return Json(json, "text/html", JsonRequestBehavior.AllowGet);
                }

            }
            else
            {
                var json = new
                {
                    okMsg = "数据输入有误"
                };

                return Json(json, "text/html", JsonRequestBehavior.AllowGet);
            }


        }
        [ApachAuthentication]
        public JObject AllWorkFlowList(int? page, int? rows)      //显示所有的流程列表
        {

            List<WorkFlowItem> list = bdb.WorkFlowItems.OrderByDescending(c => c.WfCreateDate).Skip((Convert.ToInt32(page) - 1) * Convert.ToInt32(rows)).Take(Convert.ToInt32(rows)).ToList(); ;
            JObject json = new JObject(
                new JProperty("total", bdb.WorkFlowItems.ToList().Count()),
                new JProperty("rows",
                    new JArray(
                        from r in list
                        select new JObject(
                            new JProperty("ID", r.ID),
                            new JProperty("WfInstanceId", r.WfInstanceId),
                            new JProperty("WfType", r.WfType),
                            new JProperty("WfBussinessUrl", r.WfBussinessUrl),
                            new JProperty("WfTitle", GetWfName(r.WfBusinessId)),
                            new JProperty("WfCurrentUser", r.WfCurrentUser),
                            new JProperty("Wfstatus", r.Wfstatus),
                            new JProperty("WfDrafter", GetWfDrafterName(r.WfDrafter)),
                            new JProperty("WfApplicant", GetWfApplicantName(r.WfBusinessId)),
                            new JProperty("WfCreateDate", r.WfCreateDate)))));



            return json;
        }
        [ApachAuthentication]
        public JObject ItServiceList(int? page, int? rows, string DealwithpeopleName, string isitype, string sub_isitype, string end_isitype, DateTime? logTimeB, DateTime? logTimeE)
        {

            int totalCount;
            var query = bdb.ItServiceItems.AsQueryable();
            List<ItServiceItem> list;



            totalCount = bdb.ItServiceItems.ToList().Count();

            if (!string.IsNullOrWhiteSpace(DealwithpeopleName))
            {
                query = query.Where(i => i.DealwithpeopleName.Contains(DealwithpeopleName.Trim()));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(isitype))
            {
                query = query.Where(i => i.isitype.Contains(isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(sub_isitype))
            {
                query = query.Where(i => i.sub_isitype.Contains(sub_isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(end_isitype))
            {
                query = query.Where(i => i.end_isitype.Contains(end_isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(logTimeB.ToString()) && !string.IsNullOrWhiteSpace(logTimeE.ToString()))
            {
                logTimeE = logTimeE.Value.AddDays(1);
                query = query.Where(i => i.isiCreateDate >= logTimeB && i.isiCreateDate <= logTimeE);
                //query = query.Where(w => w.logTime.ToString().Contains(logTime));
                totalCount = query.ToList().Count();
            }

            list = query.OrderByDescending(c => c.isiCreateDate).Skip((Convert.ToInt32(page) - 1) * Convert.ToInt32(rows)).Take(Convert.ToInt32(rows)).ToList();

            JObject json = new JObject(
                new JProperty("total", totalCount),
                new JProperty("rows",
                    new JArray(
                        from r in list
                        select new JObject(
                            new JProperty("ID", r.ID),
                            new JProperty("Title", r.Title),
                            new JProperty("isiAllType", GetAllIsiType(r.isitype, r.sub_isitype, r.end_isitype)),
                            new JProperty("applicant", r.applicant),
                            new JProperty("isiCreateDate", r.isiCreateDate.ToString("yyyy/MM/dd hh:mm:ss")),
                            new JProperty("DealwithpeopleName", r.DealwithpeopleName),
                            new JProperty("solution", r.solution)
                            ))));



            return json;
        }
        [ApachAuthentication]
        public ActionResult IsiExportXls(string DealwithpeopleName, string isitype, string sub_isitype, string end_isitype, DateTime? logTimeB, DateTime? logTimeE)
        {

            int totalCount;
            var query = bdb.ItServiceItems.AsQueryable();
            List<ItServiceItem> list;



            totalCount = bdb.ItServiceItems.ToList().Count();

            if (!string.IsNullOrWhiteSpace(DealwithpeopleName))
            {
                query = query.Where(i => i.DealwithpeopleName.Contains(DealwithpeopleName.Trim()));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(isitype))
            {
                query = query.Where(i => i.isitype.Contains(isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(sub_isitype))
            {
                query = query.Where(i => i.sub_isitype.Contains(sub_isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(end_isitype))
            {
                query = query.Where(i => i.end_isitype.Contains(end_isitype));
                totalCount = query.ToList().Count();
            }

            if (!string.IsNullOrWhiteSpace(logTimeB.ToString()) && !string.IsNullOrWhiteSpace(logTimeE.ToString()))
            {
                logTimeE = logTimeE.Value.AddDays(1);
                query = query.Where(i => i.isiCreateDate >= logTimeB && i.isiCreateDate <= logTimeE);
                //query = query.Where(w => w.logTime.ToString().Contains(logTime));
                totalCount = query.ToList().Count();
            }

            list = query.OrderByDescending(c => c.isiCreateDate).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("标题", typeof(string));
            dt.Columns.Add("类别", typeof(string));
            dt.Columns.Add("申请人", typeof(string));
            dt.Columns.Add("申请时间", typeof(string));
            dt.Columns.Add("处理人", typeof(string));
            dt.Columns.Add("问题描述", typeof(string));
            dt.Columns.Add("解决方法", typeof(string));

            int k = 0;
            foreach (var item in list)
            {

                DataRow dr = dt.NewRow();
                dr["标题"] = item.Title.ToString();
                dr["类别"] = GetAllIsiType(item.isitype, item.sub_isitype, item.end_isitype);
                dr["申请人"] = item.applicant;
                dr["申请时间"] = item.isiCreateDate.ToString("yyyy/MM/dd hh:mm:ss");
                dr["处理人"] = item.DealwithpeopleName;
                dr["问题描述"] = item.description;
                dr["解决方法"] = item.solution;
                dt.Rows.Add(dr);
            }
            OpenXmlExcelHelper.ExportByWeb(dt, "result.xls", "result");

            var json = new
            {
                okMsg = "导出成功"
            };

            return Json(json, "text/html", JsonRequestBehavior.AllowGet);

        }

        public string GetAllIsiType(string isitype, string sub_isitype, string end_isitype)
        {
            string str_isi = "";
            string str_subisi = "";
            string str_endisi = "";

            DataDict isi = db.DataDicts.Where(i => i.ID.ToString().Trim() == isitype.Trim()).SingleOrDefault();
            if (isi != null)
            {
                str_isi = isi.DataDictName;
            }
            DataDict subisi = db.DataDicts.Where(i => i.ID.ToString().Trim() == sub_isitype.Trim()).SingleOrDefault();
            if (subisi != null)
            {
                str_subisi = "->" + subisi.DataDictName;
            }

            DataDict endisi = db.DataDicts.Where(i => i.ID.ToString().Trim() == end_isitype.Trim()).SingleOrDefault();
            if (endisi != null)
            {
                str_endisi = "->" + endisi.DataDictName;
            }



            return str_isi + str_subisi + str_endisi;
        }
        public string GetWfName(int bid)
        {
            ItServiceItem isi = bdb.ItServiceItems.Where(i => i.ID == bid).Single();

            return isi.Title;
        }
        public string GetWfDrafterName(string Drafter)
        {
            ApplicationUser user = db.Users.Include(i => i.Roles).FirstOrDefault(i => i.UserName == Drafter.Trim());
            if (user != null)
            {
                return user.TrueName;
            }
            else
            {
                return "";
            }
        }

        public string GetWfApplicantName(int bid)
        {
            ItServiceItem isi = bdb.ItServiceItems.Where(i => i.ID == bid).Single();

            return isi.applicant;
        }


        public string orgTree()
        {

            List<Organization> list = db.Organizations.ToList();
            JArray json = new JArray(
                from r in list
                select new JObject(
                    new JProperty("id", r.ID),
                    new JProperty("parentId", r.parentId),
                    new JProperty("name", r.orgName)
                    ));


            return json.ToString();
        }

        public string getIsitype()
        {
            DataDict dd_root = db.DataDicts.Where(i => i.DataDictName == "IT服务类别").SingleOrDefault();
            List<DataDict> dd = db.DataDicts.Where(i => i.parentId == dd_root.ID).ToList();
            JArray json = new JArray(
                from r in dd
                select new JObject(
                    new JProperty("id", r.ID),
                    new JProperty("parentId", r.parentId),
                    new JProperty("name", r.DataDictName)
                    ));


            return json.ToString();
        }

        public string getSub_isitype(int id)
        {
            List<DataDict> dd = db.DataDicts.Where(i => i.parentId == id).ToList();
            JArray json = new JArray(
                from r in dd
                select new JObject(
                    new JProperty("id", r.ID),
                    new JProperty("parentId", r.parentId),
                    new JProperty("name", r.DataDictName)
                    ));


            return json.ToString();
        }

        public string getEnd_isitype(int id)
        {
            List<DataDict> dd = db.DataDicts.Where(i => i.parentId == id).ToList();
            JArray json = new JArray(
                from r in dd
                select new JObject(
                    new JProperty("id", r.ID),
                    new JProperty("parentId", r.parentId),
                    new JProperty("name", r.DataDictName)
                    ));


            return json.ToString();
        }



        private static Activity CreateActivityFrom(string xaml)
        {

            var xamlSettings = new XamlXmlReaderSettings { LocalAssembly = Assembly.GetExecutingAssembly() };

            var xamlReader = ActivityXamlServices
                .CreateReader(new XamlXmlReader(xaml, xamlSettings));
            Activity activity = ActivityXamlServices.Load(xamlReader);
            return activity;
        }

        private static InstanceStore CreateInstanceStore()
        {
            var conn = ConfigurationManager.ConnectionStrings["ApacheConnection"].ConnectionString;
            var store = new SqlWorkflowInstanceStore(conn)
            {
                InstanceLockedExceptionAction = InstanceLockedExceptionAction.AggressiveRetry,
                InstanceCompletionAction = InstanceCompletionAction.DeleteNothing,
                HostLockRenewalPeriod = TimeSpan.FromSeconds(20),
                RunnableInstancesDetectionPeriod = TimeSpan.FromSeconds(3)
            };
            StateMachineStateTracker.Promote(store);
            var handle = store.CreateInstanceHandle();
            var view = store.Execute(handle, new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(60));
            store.DefaultInstanceOwner = view.InstanceOwner;

            handle.Free();

            return store;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                bdb.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}