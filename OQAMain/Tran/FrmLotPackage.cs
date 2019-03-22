using Syncfusion.Windows.Forms;
using OQA_Core;
using System;
using System.Windows.Forms;
using WCFModels.OQA;
using WCFModels.Message;
using System.Collections.Generic;
using WcfClientCore.Utils.Authority;

namespace OQAMain
{
    public partial class FrmLotPackage : OQABaseForm
    {
        #region " Windows Form auto generated code "
        public FrmLotPackage()
        {
            InitializeComponent();
        }

        #endregion


        #region " Constant Definition "
        //private bool b_load_flag = false;
        private LotPackageView lotPackageInfo;
        #endregion


        #region " Variable Definition "
        //private bool b_load_flag  ;
        #endregion


        #region " Function Definition "

        #region " 事务前数据检查 "
        private bool CheckCondition(string FuncName)
        {
            switch (ComFunc.Trim(FuncName))
            {
                case "CREATE":
                case "UPDATE":
                    // TODO
                    return ValidateLotInfo();
 
                case "DELETE":
                    // TODO
                    break;
            }

            return true;

        }

        private bool ValidateLotInfo()
        {
            if (null == lotPackageInfo || string.IsNullOrEmpty(lotId_textBox.Text.Trim()))
            {
                MessageBox.Show("无Lot信息！");
                lotId_textBox.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region "控件初始化 "        
        private void ClearData(string ProcStep)
        {

            try
            {
                switch (ProcStep)
                {
                    case "1":
                        //Initialize
                        ComFunc.FieldClear(this);
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion

        private void lotId_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ComFunc.CheckEnterKey(e))
            {
                //查询当前输入的lot
                QueryCurrentLotPackInfo();
            }
        }

        private void QueryCurrentLotPackInfo()
        {
            string lotId = lotId_textBox.Text.Trim();
            if (string.IsNullOrEmpty(lotId))
            {
                MessageBox.Show("请输入lotID");
                lotId_textBox.Focus();
                return;
            }

            var res = QueryLotPackageInfo(lotId);
            if (res._success)
            {
                lotPackageInfo = res.model;
                InitImageControl(lotPackageInfo.packageImgList);
                Fosb_imageUpload.Focus();
            }
            else
            {
                MessageBox.Show(res._ErrorMsg);
                lotId_textBox.Focus();
            }
        }

        private ModelRsp<LotPackageView> QueryLotPackageInfo(string lotIdInput)
        {
            LotPackageInput input = new LotPackageInput()
            {
                lotId = lotIdInput
            };
            try
            {
                return OQASrv.Call.QueryLotPackageInfo(input);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        private void InitImageControl(List<ISPIMGDEF> imageList)
        {
            foreach (ISPIMGDEF img in imageList)
            {
                switch(img.ImageType)
                {
                    case ImageType.PAK_A:
                        Attachment_imageUpload.InitByImgInstance(img);
                        break;
                    case ImageType.PAK_F:
                        Fosb_imageUpload.InitByImgInstance(img);
                        break;
                    case ImageType.PAK_P:
                        PackageType_imageUpload.InitByImgInstance(img);
                        break;
                    case ImageType.PAK_S:
                        ShipLabel_imageUpload.InitByImgInstance(img);
                        break;
                }
            }

            EnableImageControl();
        }

        private void ClearImageControl()
        {
            Attachment_imageUpload.RefreshContrl();
            Fosb_imageUpload.RefreshContrl();
            PackageType_imageUpload.RefreshContrl();
            ShipLabel_imageUpload.RefreshContrl();
        }

        private void EnableImageControl()
        {
            Attachment_imageUpload.Enabled = true;
            Fosb_imageUpload.Enabled = true;
            PackageType_imageUpload.Enabled = true;
            ShipLabel_imageUpload.Enabled = true;
        }

        private void DisableImageControl()
        {
            ClearImageControl();
            Attachment_imageUpload.Enabled = false;
            Fosb_imageUpload.Enabled = false;
            PackageType_imageUpload.Enabled = false;
            ShipLabel_imageUpload.Enabled = false;
        }
        #endregion

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (!CheckCondition("UPDATE")) return;

            lotPackageInfo.lotInfo.Status = WCFModels.OQA.LotSts.PackageOut;
            lotPackageInfo.lotInfo.UpdateUserId = AuthorityControl.GetUserProfile().userId;
            UpdateModelReq<ISPLOTSTS> updateReq = new UpdateModelReq<ISPLOTSTS>
            {
                operateType = OperateType.Update,
                model = lotPackageInfo.lotInfo,
                partialUpdate = false,
                userId = AuthorityControl.GetUserProfile().userId
            };
            try
            {
                var res = OQASrv.Call.UpdateLotSts(updateReq);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //删除已上传的图片
                DeleteImg(lotPackageInfo.lotInfo.LotId);
                ClearImageControl();
                return;
            }

            MessageBox.Show("Lot package submitted!");
            ClearForm();
        }

        private void DeleteImg(string lotID)
        {
            DeletePackageImgReq req = new DeletePackageImgReq()
            {
                lotId = lotID
            };
            try
            {
                OQASrv.Call.DeletePackageImg(req);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Fosb_imageUpload_btnUploadClicked(object sender, EventArgs e)
        {
            Fosb_imageUpload.UploadBylot(lotId_textBox.Text.Trim(), ImageType.PAK_F);
        }

        private void ShipLabel_imageUpload_btnUploadClicked(object sender, EventArgs e)
        {
            ShipLabel_imageUpload.UploadBylot(lotId_textBox.Text.Trim(), ImageType.PAK_S);
        }

        private void PackageType_imageUpload_btnUploadClicked(object sender, EventArgs e)
        {
            PackageType_imageUpload.UploadBylot(lotId_textBox.Text.Trim(), ImageType.PAK_P);
        }

        private void Attachment_imageUpload_btnUploadClicked(object sender, EventArgs e)
        {
            Attachment_imageUpload.UploadBylot(lotId_textBox.Text.Trim(), ImageType.PAK_A);
        }

        private void lotId_textBox_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lotId_textBox.Text = string.Empty;
            lotPackageInfo = null;
            DisableImageControl();
        }

        private void Fosb_imageUpload_PreviewLableClicked(object sender, EventArgs e)
        {
            string path = Fosb_imageUpload.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
        }

        private void ShipLabel_imageUpload_PreviewLableClicked(object sender, EventArgs e)
        {
            string path = ShipLabel_imageUpload.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
        }

        private void PackageType_imageUpload_PreviewLableClicked(object sender, EventArgs e)
        {
            string path = PackageType_imageUpload.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
        }

        private void Attachment_imageUpload_PreviewLableClicked(object sender, EventArgs e)
        {
            string path = Attachment_imageUpload.GetImagePath();
            if (!string.IsNullOrEmpty(path))
            {
                pictureView.LoadImageAsync(ComFunc.GetPicServerPath(path));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!CheckCondition("CREATE")) return;
            MessageBox.Show("Lot package info saved!");
            ClearForm();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            FrmPackageLabelPrint frm = new FrmPackageLabelPrint(lotId_textBox.Text.Trim());
            AddNewFormToMdi(frm);
        }
    }
}