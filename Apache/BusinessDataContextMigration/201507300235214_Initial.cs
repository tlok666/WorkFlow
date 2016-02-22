namespace Apache.BusinessDataContextMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItServiceItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        isitype = c.String(),
                        sub_isitype = c.String(),
                        end_isitype = c.String(),
                        drafter = c.String(),
                        applicant = c.String(),
                        applicantPhone = c.String(),
                        applicant_dept = c.String(),
                        description = c.String(),
                        solution = c.String(),
                        DealwithpeopleName = c.String(),
                        ItManagerOpinion = c.String(),
                        ProcessingDepartmentOpinion = c.String(),
                        DealwithpeopleOpinion = c.String(),
                        isiCreateDate = c.DateTime(nullable: false),
                        isiCompleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WorkFlowItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WfInstanceId = c.Guid(nullable: false),
                        WfType = c.String(),
                        WfBusinessId = c.Int(nullable: false),
                        WfBussinessUrl = c.String(),
                        WfCurrentUser = c.String(),
                        WfDrafter = c.String(),
                        Wfstatus = c.String(),
                        WfCreateDate = c.DateTime(nullable: false),
                        WfCompleteDate = c.DateTime(),
                        WfFlowChart = c.String(),
                        WfWriteField = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.GuaredFamily",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        sName = c.String(),
                        sIdentityNum = c.String(),
                        bSex = c.Boolean(nullable: false),
                        sRace = c.String(),
                        sFamilyAddress = c.String(),
                        sBirthMonth = c.DateTime(nullable: false),
                        iPopulation = c.Int(nullable: false),
                        bIsDisable = c.Boolean(nullable: false),
                        Member1_sName = c.String(),
                        Member1_sRelationship = c.String(),
                        Member1_bSex = c.Boolean(nullable: false),
                        Member1_iAge = c.Int(nullable: false),
                        Member1_bDisable = c.Boolean(nullable: false),
                        Member1_sIdentity = c.String(),
                        Member2_sName = c.String(),
                        Member2_sRelationship = c.String(),
                        Member2_bSex = c.Boolean(nullable: false),
                        Member2_iAge = c.Int(nullable: false),
                        Member2_bDisable = c.Boolean(nullable: false),
                        Member2_sIdentity = c.String(),
                        Member3_sName = c.String(),
                        Member3_sRelationship = c.String(),
                        Member3_bSex = c.Boolean(nullable: false),
                        Member3_iAge = c.Int(nullable: false),
                        Member3_bDisable = c.Boolean(nullable: false),
                        Member3_sIdentity = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkFlowItems");
            DropTable("dbo.ItServiceItems");
            DropTable("dbo.GuaredFamilyItems");
        }
    }
}
