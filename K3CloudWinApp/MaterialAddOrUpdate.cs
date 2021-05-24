using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3CloudWinApp
{
    public partial class MaterialAddOrUpdate : Form
    {
        public MaterialAddOrUpdate()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string jsonStr = "{" + 
                "'NeedUpDateFields': []," + 
                "'NeedReturnFields': ['FMATERIALID','FNUMBER']," +
                "'IsDeleteEntry': 'true'," +
                "'SubSystemId': ''," +
                "'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," + 
                " 'ValidateFlag': 'true'," +
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," + 
                "'Model': {" +
                "'FMATERIALID': 0,"  +
                "'FCreateOrgId': {" +  //创建组织
                "'FNumber': '101.2'" + 
                "}," +
                "'FUseOrgId': {" + //使用组织
                "'FNumber': '101.2'" +
                "}," + 
                "'FNumber': ''," +  //更新时可以
                "'FName': '测试',"  + // 名称
                "'SubHeadEntity': {" +
                "'FErpClsID': '1'," +//物料属性
                //"'FFeatureItem': '',"+ //特征件子项  没搜到
                "'FCategoryID': {" + //存货类别
                    "'FNumber': 'CHLB01_SYS'" +
                "}," +
                "'FBaseUnitId': {" + // 基本单位
                    "'FNumber': 'Pcs'" +
                "}," +
                "'FSuite': '0'" + //套件
                "}," +
                "'SubHeadEntity1': {" +
                    "'FStoreUnitID': {" + //库存单位
                        "'FNumber': 'Pcs'" + 
                    "}," +
                    "'FUnitConvertDir': '1'," + //换算方向    '1':基本单位->辅助单位    '2':辅助单位->基本单位
                    "'FCurrencyId': {" + //币别
                        "'FNumber': 'PRE001'" + //这里选人民币
                    "}," + 
                    "'FSNManageType': ''," +//业务范围
                    "'FSNGenerateTime': ''" + //序列号生成时机
                "}," +
                "'SubHeadEntity2': {" +
                    "'FSaleUnitId': {" + //销售单位
                        "'FNumber': 'Pcs'" +  
                    "}," +
                    "'FSalePriceUnitId': {" + // 销售计价单位
                        "'FNumber': 'Pcs'" +
                    "}" + 
                "}," +
                "'SubHeadEntity3': {" +
                    "'FPurchaseUnitId': {" +  //采购单位
                        "'FNumber': 'Pcs'" +
                    "}," + 
                    "'FPurchasePriceUnitId': {" +  //采购计价单位
                        "'FNumber': 'Pcs'" +
                    "}," +
                    "'FQuotaType': '0'," +  //配额方式
                "}," +
                "'SubHeadEntity4': {" +
                    "'FPlanningStrategy': '1'," +   // 计划策略
                    "'FOrderPolicy': '0'," +  //订货策略
                    "'FFixLeadTimeType': '1'," + // 固定提前期单位
                    "'FVarLeadTimeType': '1'," +  //变动提前期单位
                    "'FCheckLeadTimeType': '1'," + //检验提前期单位
                    " 'FOrderIntervalTimeType': '3'," +  //订货间隔期单位
                    "'FReserveType': '1'," +  //预留类型
                    "'FPlanOffsetTimeType': '1'," +   //时间单位
                "'SubHeadEntity5': {" +     //t_BD_MaterialProduce
                    "'FIssueType': '1'," +   //发料方式
                    "'FOverControlMode': '1'," +// 超发控制方式
                    "'FMinIssueUnitId': {" +   //最小发料批量单位
                       " 'FNUMBER': 'Pcs'" +
                    "}," +
                    "'FStandHourUnitId': '3600'," +    //工时单位
                    "'FBackFlushType': '1'" +   //倒冲数量
                "}," +
                "'FEntityInvPty': [" +   //t_BD_MaterialInvPty
                    "{" +
                        "'FInvPtyId': {"  +//库存属性
                            "'FNumber': '10001'" +
                        "} } ] } }";
                    
        }
    }
}
