namespace Apache.BusinessDataContextMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuaredFamilyItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        drafter = c.String(),
                        isiCreateDate = c.DateTime(nullable: false),
                        isiCompleteDate = c.DateTime(),
                        sName = c.String(),
                        sIdentityNum = c.String(),
                        bSex = c.Boolean(nullable: false),
                        sRace = c.String(),
                        sFamilyAddress = c.String(),
                        sBirthMonth = c.DateTime(),
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
            DropTable("dbo.GuaredFamilyItems");
        }
    }
}
