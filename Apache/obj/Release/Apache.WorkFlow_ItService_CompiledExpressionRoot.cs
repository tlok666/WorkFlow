namespace Apache.WorkFlow {
    
    #line 21 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 22 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 23 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 24 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 25 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 26 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using Apache.Models;
    
    #line default
    #line hidden
    
    #line 1 "D:\ftp\RightsApprovalProcess\RightsApprovalProcess\Apache\WorkFlow\ItService.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class ItService : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = ItService_TypedDataContext3_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ItService_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext3_ForReadOnly valDataContext0 = ((ItService_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ItService_TypedDataContext3(locations, activityContext, true);
                }
                ItService_TypedDataContext3 refDataContext1 = ((ItService_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ItService_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext3_ForReadOnly valDataContext2 = ((ItService_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new ItService_TypedDataContext3(locations, activityContext, true);
                }
                ItService_TypedDataContext3 refDataContext3 = ((ItService_TypedDataContext3)(cachedCompiledDataContext[1]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ItService_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext3_ForReadOnly valDataContext4 = ((ItService_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new ItService_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext3_ForReadOnly valDataContext5 = ((ItService_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new ItService_TypedDataContext5(locations, activityContext, true);
                }
                ItService_TypedDataContext5 refDataContext6 = ((ItService_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<string>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new ItService_TypedDataContext5(locations, activityContext, true);
                }
                ItService_TypedDataContext5 refDataContext7 = ((ItService_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ItService_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext5_ForReadOnly valDataContext8 = ((ItService_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ItService_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext5_ForReadOnly valDataContext9 = ((ItService_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new ItService_TypedDataContext5(locations, activityContext, true);
                }
                ItService_TypedDataContext5 refDataContext10 = ((ItService_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ItService_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext5_ForReadOnly valDataContext11 = ((ItService_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new ItService_TypedDataContext5(locations, activityContext, true);
                }
                ItService_TypedDataContext5 refDataContext12 = ((ItService_TypedDataContext5)(cachedCompiledDataContext[2]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ItService_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext5_ForReadOnly valDataContext13 = ((ItService_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new ItService_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext5_ForReadOnly valDataContext14 = ((ItService_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new ItService_TypedDataContext6(locations, activityContext, true);
                }
                ItService_TypedDataContext6 refDataContext15 = ((ItService_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new ItService_TypedDataContext6(locations, activityContext, true);
                }
                ItService_TypedDataContext6 refDataContext16 = ((ItService_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ItService_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext6_ForReadOnly valDataContext17 = ((ItService_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ItService_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext6_ForReadOnly valDataContext18 = ((ItService_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new ItService_TypedDataContext6(locations, activityContext, true);
                }
                ItService_TypedDataContext6 refDataContext19 = ((ItService_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ItService_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext6_ForReadOnly valDataContext20 = ((ItService_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new ItService_TypedDataContext6(locations, activityContext, true);
                }
                ItService_TypedDataContext6 refDataContext21 = ((ItService_TypedDataContext6)(cachedCompiledDataContext[4]));
                return refDataContext21.GetLocation<string>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ItService_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext6_ForReadOnly valDataContext22 = ((ItService_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new ItService_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext6_ForReadOnly valDataContext23 = ((ItService_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ItService_TypedDataContext7(locations, activityContext, true);
                }
                ItService_TypedDataContext7 refDataContext24 = ((ItService_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new ItService_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext7_ForReadOnly valDataContext25 = ((ItService_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new ItService_TypedDataContext7(locations, activityContext, true);
                }
                ItService_TypedDataContext7 refDataContext26 = ((ItService_TypedDataContext7)(cachedCompiledDataContext[6]));
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new ItService_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext7_ForReadOnly valDataContext27 = ((ItService_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new ItService_TypedDataContext8(locations, activityContext, true);
                }
                ItService_TypedDataContext8 refDataContext28 = ((ItService_TypedDataContext8)(cachedCompiledDataContext[8]));
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ItService_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext8_ForReadOnly valDataContext29 = ((ItService_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new ItService_TypedDataContext8(locations, activityContext, true);
                }
                ItService_TypedDataContext8 refDataContext30 = ((ItService_TypedDataContext8)(cachedCompiledDataContext[8]));
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ItService_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext8_ForReadOnly valDataContext31 = ((ItService_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ItService_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext8_ForReadOnly valDataContext32 = ((ItService_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = ItService_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 10);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new ItService_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                ItService_TypedDataContext8_ForReadOnly valDataContext33 = ((ItService_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext33.ValueType___Expr33Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                ItService_TypedDataContext3_ForReadOnly valDataContext0 = new ItService_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                ItService_TypedDataContext3 refDataContext1 = new ItService_TypedDataContext3(locations, true);
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                ItService_TypedDataContext3_ForReadOnly valDataContext2 = new ItService_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                ItService_TypedDataContext3 refDataContext3 = new ItService_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                ItService_TypedDataContext3_ForReadOnly valDataContext4 = new ItService_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                ItService_TypedDataContext3_ForReadOnly valDataContext5 = new ItService_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                ItService_TypedDataContext5 refDataContext6 = new ItService_TypedDataContext5(locations, true);
                return refDataContext6.GetLocation<string>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                ItService_TypedDataContext5 refDataContext7 = new ItService_TypedDataContext5(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                ItService_TypedDataContext5_ForReadOnly valDataContext8 = new ItService_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                ItService_TypedDataContext5_ForReadOnly valDataContext9 = new ItService_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                ItService_TypedDataContext5 refDataContext10 = new ItService_TypedDataContext5(locations, true);
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                ItService_TypedDataContext5_ForReadOnly valDataContext11 = new ItService_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                ItService_TypedDataContext5 refDataContext12 = new ItService_TypedDataContext5(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                ItService_TypedDataContext5_ForReadOnly valDataContext13 = new ItService_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                ItService_TypedDataContext5_ForReadOnly valDataContext14 = new ItService_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                ItService_TypedDataContext6 refDataContext15 = new ItService_TypedDataContext6(locations, true);
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                ItService_TypedDataContext6 refDataContext16 = new ItService_TypedDataContext6(locations, true);
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                ItService_TypedDataContext6_ForReadOnly valDataContext17 = new ItService_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                ItService_TypedDataContext6_ForReadOnly valDataContext18 = new ItService_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                ItService_TypedDataContext6 refDataContext19 = new ItService_TypedDataContext6(locations, true);
                return refDataContext19.GetLocation<string>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                ItService_TypedDataContext6_ForReadOnly valDataContext20 = new ItService_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                ItService_TypedDataContext6 refDataContext21 = new ItService_TypedDataContext6(locations, true);
                return refDataContext21.GetLocation<string>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                ItService_TypedDataContext6_ForReadOnly valDataContext22 = new ItService_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                ItService_TypedDataContext6_ForReadOnly valDataContext23 = new ItService_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                ItService_TypedDataContext7 refDataContext24 = new ItService_TypedDataContext7(locations, true);
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                ItService_TypedDataContext7_ForReadOnly valDataContext25 = new ItService_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                ItService_TypedDataContext7 refDataContext26 = new ItService_TypedDataContext7(locations, true);
                return refDataContext26.GetLocation<string>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                ItService_TypedDataContext7_ForReadOnly valDataContext27 = new ItService_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext27.ValueType___Expr27Get();
            }
            if ((expressionId == 28)) {
                ItService_TypedDataContext8 refDataContext28 = new ItService_TypedDataContext8(locations, true);
                return refDataContext28.GetLocation<string>(refDataContext28.ValueType___Expr28Get, refDataContext28.ValueType___Expr28Set);
            }
            if ((expressionId == 29)) {
                ItService_TypedDataContext8_ForReadOnly valDataContext29 = new ItService_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext29.ValueType___Expr29Get();
            }
            if ((expressionId == 30)) {
                ItService_TypedDataContext8 refDataContext30 = new ItService_TypedDataContext8(locations, true);
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                ItService_TypedDataContext8_ForReadOnly valDataContext31 = new ItService_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                ItService_TypedDataContext8_ForReadOnly valDataContext32 = new ItService_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                ItService_TypedDataContext8_ForReadOnly valDataContext33 = new ItService_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "WfIn.drafter") 
                        && (ItService_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NextLink") 
                        && (ItService_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WfIn") 
                        && (ItService_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"向乡镇民政办提交申请\"") 
                        && (ItService_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NextLink") 
                        && (ItService_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WfIn") 
                        && (ItService_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"乡镇民政办领导\"") 
                        && (ItService_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink==\"驳回\"") 
                        && (ItService_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NextLink") 
                        && (ItService_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WfIn") 
                        && (ItService_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OpinionField") 
                        && (ItService_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"县民政局股室\"") 
                        && (ItService_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"驳回\"") 
                        && (ItService_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NextLink") 
                        && (ItService_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WfIn") 
                        && (ItService_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "CurrentUser") 
                        && (ItService_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "NextLink") 
                        && (ItService_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "WfIn") 
                        && (ItService_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"结束流程\"") 
                        && (ItService_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "NextLink == \"驳回\"") 
                        && (ItService_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new ItService_TypedDataContext3_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new ItService_TypedDataContext3(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new ItService_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new ItService_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new ItService_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new ItService_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new ItService_TypedDataContext5(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new ItService_TypedDataContext5(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new ItService_TypedDataContext5_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new ItService_TypedDataContext5_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new ItService_TypedDataContext5(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new ItService_TypedDataContext5_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new ItService_TypedDataContext5(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new ItService_TypedDataContext5_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new ItService_TypedDataContext5_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new ItService_TypedDataContext6(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new ItService_TypedDataContext6(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new ItService_TypedDataContext6_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new ItService_TypedDataContext6_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new ItService_TypedDataContext6(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new ItService_TypedDataContext6_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new ItService_TypedDataContext6(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new ItService_TypedDataContext6_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new ItService_TypedDataContext6_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new ItService_TypedDataContext7(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new ItService_TypedDataContext7_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new ItService_TypedDataContext7(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new ItService_TypedDataContext7_ForReadOnly(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new ItService_TypedDataContext8(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new ItService_TypedDataContext8_ForReadOnly(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new ItService_TypedDataContext8(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new ItService_TypedDataContext8_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new ItService_TypedDataContext8_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new ItService_TypedDataContext8_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext1 : ItService_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Apache.Models.WorkFlowInParameter WfIn {
                get {
                    return ((Apache.Models.WorkFlowInParameter)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "WfIn") 
                            || (locationReferences[(offset + 0)].Type != typeof(Apache.Models.WorkFlowInParameter)))) {
                    return false;
                }
                return ItService_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext1_ForReadOnly : ItService_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Apache.Models.WorkFlowInParameter WfIn {
                get {
                    return ((Apache.Models.WorkFlowInParameter)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "WfIn") 
                            || (locationReferences[(offset + 0)].Type != typeof(Apache.Models.WorkFlowInParameter)))) {
                    return false;
                }
                return ItService_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext2 : ItService_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CurrentUser {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string NextLink {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string OpinionField {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 1)].Name != "CurrentUser") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "NextLink") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "OpinionField") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                return ItService_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext2_ForReadOnly : ItService_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string CurrentUser {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string NextLink {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string OpinionField {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 1)].Name != "CurrentUser") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "NextLink") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "OpinionField") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                return ItService_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext3 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 101 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 101 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(string value) {
                
                #line 101 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                  CurrentUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 118 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  NextLink;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 118 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                  NextLink;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 118 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                  NextLink = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext3_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 106 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  WfIn.drafter;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 106 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                  WfIn.drafter;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 113 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 113 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 123 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Apache.Models.WorkFlowInParameter>> expression = () => 
                  WfIn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Apache.Models.WorkFlowInParameter @__Expr4Get() {
                
                #line 123 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                  WfIn;
                
                #line default
                #line hidden
            }
            
            public Apache.Models.WorkFlowInParameter ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 132 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              NextLink == "向乡镇民政办提交申请";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr5Get() {
                
                #line 132 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
              NextLink == "向乡镇民政办提交申请";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext4 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext4_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext5 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 141 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 141 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(string value) {
                
                #line 141 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                          CurrentUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 151 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 151 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 151 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                          OpinionField = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 171 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          NextLink;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 171 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          NextLink;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(string value) {
                
                #line 171 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                          NextLink = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 183 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 183 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 183 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                          OpinionField = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext5_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 166 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 166 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 161 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 161 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 176 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Apache.Models.WorkFlowInParameter>> expression = () => 
                          WfIn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Apache.Models.WorkFlowInParameter @__Expr11Get() {
                
                #line 176 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                          WfIn;
                
                #line default
                #line hidden
            }
            
            public Apache.Models.WorkFlowInParameter ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 197 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      NextLink == "乡镇民政办领导";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 197 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                      NextLink == "乡镇民政办领导";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 365 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      NextLink=="驳回";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr14Get() {
                
                #line 365 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                      NextLink=="驳回";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext6 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 206 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 206 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(string value) {
                
                #line 206 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                  CurrentUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 216 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 216 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(string value) {
                
                #line 216 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                  OpinionField = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 236 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  NextLink;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 236 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  NextLink;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(string value) {
                
                #line 236 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                  NextLink = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 248 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 248 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(string value) {
                
                #line 248 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                  OpinionField = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext6_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 231 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  OpinionField;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 231 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  OpinionField;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 226 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 226 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 241 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Apache.Models.WorkFlowInParameter>> expression = () => 
                                  WfIn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Apache.Models.WorkFlowInParameter @__Expr20Get() {
                
                #line 241 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                  WfIn;
                
                #line default
                #line hidden
            }
            
            public Apache.Models.WorkFlowInParameter ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 262 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              NextLink == "县民政局股室";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 262 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                              NextLink == "县民政局股室";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 356 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              NextLink == "驳回";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 356 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                              NextLink == "驳回";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext7 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 271 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 271 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                          CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(string value) {
                
                #line 271 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                          CurrentUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 286 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          NextLink;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 286 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                          NextLink;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(string value) {
                
                #line 286 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                          NextLink = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext7_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 281 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                          CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 281 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                          CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 291 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Apache.Models.WorkFlowInParameter>> expression = () => 
                                          WfIn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Apache.Models.WorkFlowInParameter @__Expr27Get() {
                
                #line 291 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                          WfIn;
                
                #line default
                #line hidden
            }
            
            public Apache.Models.WorkFlowInParameter ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext8 : ItService_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 306 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 306 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr28Set(string value) {
                
                #line 306 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                                  CurrentUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr28Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr28Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 321 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  NextLink;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 321 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                                  NextLink;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(string value) {
                
                #line 321 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                
                                                  NextLink = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class ItService_TypedDataContext8_ForReadOnly : ItService_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public ItService_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public ItService_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 316 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                                  CurrentUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 316 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                                  CurrentUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 326 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<Apache.Models.WorkFlowInParameter>> expression = () => 
                                                  WfIn;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Apache.Models.WorkFlowInParameter @__Expr31Get() {
                
                #line 326 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                                  WfIn;
                
                #line default
                #line hidden
            }
            
            public Apache.Models.WorkFlowInParameter ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 335 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              NextLink == "结束流程";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr32Get() {
                
                #line 335 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                              NextLink == "结束流程";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 343 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                                              NextLink == "驳回";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr33Get() {
                
                #line 343 "D:\FTP\RIGHTSAPPROVALPROCESS\RIGHTSAPPROVALPROCESS\APACHE\WORKFLOW\ITSERVICE.XAML"
                return 
                                              NextLink == "驳回";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                return ItService_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
