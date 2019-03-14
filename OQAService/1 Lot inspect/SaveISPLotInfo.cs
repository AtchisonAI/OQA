using NPoco;
using OQAContract;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using WCFModels;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;
using WCFModels.OQA;

namespace OQAService.Services
{
    public partial class OQAService : OQABaseService, IOQAContract
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public ModelRsp<ISPLotSave> SaveISPLotInfo(ModelRsp<ISPLotSave> ISPLotSave)
        {
            
            string _msg =" ";
            //定义服务过程中使用的结构

            PageQueryReq PageQueryReq = new PageQueryReq()
            {
                queryConditionList = new List<QueryCondition>(),
                sortCondittionList = new List<SortCondition>()
            };

            ModelRsp<ISPLotSave> In_node = new ModelRsp<ISPLotSave>();         //定义服务传入系统数据结构
            ModelRsp<ISPLotSave> Out_node = new ModelRsp<ISPLotSave>();        //定义服务传出系统数据结构
                                                                             //DefectCodeSave Out_list = new DefectCodeSave();                          //定义服务传出业务数据结构

            UpdateModelListReq<ISPLOTSTS> ISPLOTSTS_Save = new UpdateModelListReq<ISPLOTSTS>();//定义数据库操作新增动作传入结构
            ModelListRsp<ISPLOTSTS> ISPLOTSTS_message = new ModelListRsp<ISPLOTSTS>();         //定义数据库操作新增动作输出结构
            ISPLOTSTS T_ISPLOTSTS = new ISPLOTSTS(); //定义临时表结构


            UpdateModelListReq<ISPWAFST> ISPWAFSTS_Save = new UpdateModelListReq<ISPWAFST>();//定义数据库操作新增动作传入结构
            ModelListRsp<ISPWAFST> ISPWAFSTS_message = new ModelListRsp<ISPWAFST>();         //定义数据库操作新增动作输出结构


            UpdateModelListReq<ISPWAFITM> ISPWAFITM_Save = new UpdateModelListReq<ISPWAFITM>();//定义数据库操作新增动作传入结构
            ModelListRsp<ISPWAFITM> ISPWAFITM_message = new ModelListRsp<ISPWAFITM>();         //定义数据库操作新增动作输出结构
            
            //传入数据赋值
            In_node.model = ISPLotSave.model;
            //验证系统级别输入参数

            if (In_node.model.C_PROC_STEP.Equals("") == true)
            {
                Out_node._success = false;
                Out_node._ErrorMsg = "C_PROC_STEP is null!";
                return Out_node;

            }
            if (In_node.model.C_TRAN_FLAG.Equals("") == true)
            {
                Out_node._success = false;
                Out_node._ErrorMsg = "C_TRAN_FLAG is null!";
                return Out_node;

            }

            if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_CREATE)
            {
                //业务逻辑选择
                switch (In_node.model.C_TRAN_FLAG)
                {
                    case '1':
                        //验证业务级输入参数

                        //传入数据赋值
                        string SysTime = GetSysTime();
                        T_ISPLOTSTS.LotId = ISPLotSave.model.ISPMESLOT_List[0].Lotid;
                        T_ISPLOTSTS.FoupId = ISPLotSave.model.ISPMESLOT_List[0].Foupid;
                        T_ISPLOTSTS.PartId = ISPLotSave.model.ISPMESLOT_List[0].Partid;
                        T_ISPLOTSTS.Qty = ISPLotSave.model.ISPMESLOT_List[0].Qty;
                        T_ISPLOTSTS.RecUser = ISPLotSave.model.S_USER_ID;
                        T_ISPLOTSTS.Status = ISPStatus.Create;
                        T_ISPLOTSTS.InspectResult = IspResult.Create;
                        T_ISPLOTSTS.PartDesc = ISPLotSave.model.ISPMESLOT_List[0].Partid;
                        T_ISPLOTSTS.ProductDieQty = ISPLotSave.model.ISPMESLOT_List[0].Dieqty;
                     if (string.IsNullOrWhiteSpace(ISPLotSave.model.S_USER_NAME))
                        {
                            T_ISPLOTSTS.RecUserName = ISPLotSave.model.S_USER_ID;
                        }
                        else
                        {
                            T_ISPLOTSTS.RecUserName = ISPLotSave.model.S_USER_NAME;
                        }
                        T_ISPLOTSTS.RecDate = SysTime;
                        T_ISPLOTSTS.RecShift = ISPLotSave.model.S_REC_SHIFT;
                        T_ISPLOTSTS.Phone = ISPLotSave.model.S_PHONE;
                        T_ISPLOTSTS.LotType = ISPLotSave.model.ISPMESLOT_List[0].Lottype;
                        T_ISPLOTSTS.Stage = ISPLotSave.model.ISPMESLOT_List[0].Stage;
                        T_ISPLOTSTS.Dept = ISPLotSave.model.S_DEPT;
                        T_ISPLOTSTS.CustomerId = ISPLotSave.model.ISPMESLOT_List[0].Vendorname;
                        T_ISPLOTSTS.CustLotId = ISPLotSave.model.ISPMESLOT_List[0].Vendorlotno;
                        T_ISPLOTSTS.CustPartId = ISPLotSave.model.ISPMESLOT_List[0].Orderno;
                        T_ISPLOTSTS.OrignalCountry = "China";
                        T_ISPLOTSTS.CreateTime = SysTime;
                        T_ISPLOTSTS.CreateUserId = ISPLotSave.model.S_USER_ID;

                        //调用数据库操作
                        InitTable(T_ISPLOTSTS);
                        ISPLOTSTS_Save.operateType = OperateType.Insert;
                        ISPLOTSTS_Save.models.Add(T_ISPLOTSTS);
                        //执行
                        UpdateModels(ISPLOTSTS_Save, ISPLOTSTS_message, true);
                        if (ISPLOTSTS_message._success == false)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = ISPLOTSTS_message._ErrorMsg;
                            return Out_node;
                        }
                        //查询检验项目
                        PageQueryReq.CurrentPage = 1;
                        PageQueryReq.ItemsPerPage = 200;

                        AddSortCondition(PageQueryReq, GetParaName<ISPITMDEF>(p => p.InspectType), SortType.ASC);

                        var IspItemData = PageQuery<ISPITMDEF>(PageQueryReq);


                        //选择13片                                             
                        List<int> chooseList = new List<int>();
                        if (In_node.model.ISPMESWAFER_List.Count > 13)
                        {            
                            int[] ispnum;
                            int chosecount = 13;
                            ispnum = ChooseIspWafer(chosecount, In_node.model.ISPMESWAFER_List.Count);
                            chooseList.AddRange(ispnum);  //将数组添加到List
                        }


                         
                        int rowIndex = 1;
                        //wafer数据生成
                        foreach (OqaMeswafer wafer in In_node.model.ISPMESWAFER_List)
                        {
                            ISPWAFST T_ISPWAFSTS = new ISPWAFST(); //定义临时表结构
                            T_ISPWAFSTS.LotId = wafer.Lotid;
                            T_ISPWAFSTS.SlotId = wafer.Slotid;
                            T_ISPWAFSTS.WaferId = wafer.Waferid;
                            T_ISPWAFSTS.CreateTime = SysTime;
                            T_ISPWAFSTS.CreateUserId = ISPLotSave.model.S_USER_ID;
                            InitTable(T_ISPWAFSTS);
                            ISPWAFSTS_Save.models.Add(T_ISPWAFSTS);
                            //检验项目生成
                            foreach (ISPITMDEF ispitem in IspItemData.models)
                            {
                                ISPWAFITM T_ISPWAFITM = new ISPWAFITM(); //定义临时表结构
                                T_ISPWAFITM.LotId = wafer.Lotid;
                                T_ISPWAFITM.SlotId = wafer.Slotid;
                                T_ISPWAFITM.WaferId = wafer.Waferid;
                                T_ISPWAFITM.SideType = ispitem.SideType;
                                T_ISPWAFITM.InspectType = ispitem.InspectType;
                                T_ISPWAFITM.SideType = ispitem.SideType;
                                switch (ispitem.InspectRuleCode.Trim())
                                {
                                    case "ALL":
                                        T_ISPWAFITM.IsInspect = "Y";
                                        break;

                                    case "C_13":
                                        if (In_node.model.ISPMESWAFER_List.Count > 13 && chooseList.Contains(rowIndex) == true)
                                            //ispnum.ord(rowIndex)== true)
                                        {
                                            T_ISPWAFITM.IsInspect = "Y";
                                        }
                                        else
                                        {
                                            T_ISPWAFITM.IsInspect = "N";
                                        }

                                        break;
                                }
                                T_ISPWAFITM.InspectPoint = ispitem.InspectPoint;
                                T_ISPWAFITM.CreateUserId = ISPLotSave.model.S_USER_ID;
                                T_ISPWAFITM.CreateTime = SysTime;
                                InitTable(T_ISPWAFITM);
                                ISPWAFITM_Save.models.Add(T_ISPWAFITM);

                            }

                            rowIndex = rowIndex +1;
                        }
                        //保存wafer
                        ISPWAFSTS_Save.operateType = OperateType.Insert;
                        //执行
                        UpdateModels(ISPWAFSTS_Save, ISPWAFSTS_message, true);
                        if (ISPWAFSTS_message._success == false)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = ISPWAFSTS_message._ErrorMsg;
                            return Out_node;
                        }

                        ISPWAFITM_Save.operateType = OperateType.Insert;
                        //执行
                        UpdateModels(ISPWAFITM_Save, ISPWAFITM_message, true);
                        if (ISPWAFSTS_message._success == false)
                        {
                            Out_node._success = false;
                            Out_node._ErrorMsg = ISPWAFITM_message._ErrorMsg;
                            return Out_node;
                        }






                        break;

                        //case '2':

                        //    // TODO

                        //    break;
                }

            }

            if (In_node.model.C_PROC_STEP == GlobalConstant.TRAN_UPDATE)
                {
                    //业务逻辑选择
                    switch (In_node.model.C_TRAN_FLAG)
                    {
                    case '1':
                        //验证业务级输入参数


                        break;

                }

            }


            Out_node._success = true;
            Out_node._MsgCode = "Program Success.";

            return Out_node;

        }



        }

    }

