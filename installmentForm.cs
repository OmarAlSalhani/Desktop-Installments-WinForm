using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace installmentsApp
{
    public partial class installmentForm : Form
    {
        public installmentForm()
        {
            InitializeComponent();
        }
        DataTable Table;
        private bool ValidateAdd()
        {
            if (gunaDataGridView1.Rows.Count == 0)
            {              
                return false;
            }
            return true;
        }
        private void IncreaseQuantity()
        {
            int Bill_id = Convert.ToInt32(Bill_idTB.Text);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from CashSellFatoraBodyTable where bill_id=" + Bill_id, ConnectionClass.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int Quantity = Convert.ToInt32(dataTable.Rows[i]["quantity"]);
                string ProductName = dataTable.Rows[i]["product_name"].ToString();
                command.CommandText = "update productstable set product_quantity=product_quantity+" + Quantity + "where product_name='" + ProductName + "'";
                command.ExecuteNonQuery();
            }
            DeleteLastFatora();

        }
        private void DeleteLastFatora()
        {
            SqlCommand command = new SqlCommand("Delete from CashFatoraHeadTable where bill_id=" + Convert.ToInt32(Bill_idTB.Text), ConnectionClass.connection);
            SqlCommand command2 = new SqlCommand("Delete from CashSellFatoraBodyTable where bill_id=" + Convert.ToInt32(Bill_idTB.Text), ConnectionClass.connection);
            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }
        private void CalcualteNetAmount()
        {
            float Benefits = float.Parse(BenefitsTB.Text);
            float Total = float.Parse(TotalAmountTB.Text);
            float FirstPay = float.Parse(FirstPayTB.Text);
            NetAmountTB.Text = ((Total + Benefits) - FirstPay).ToString();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            IncreaseQuantity();
            this.Close();
        }

        private void BenefitsTB_EditValueChanged(object sender, EventArgs e)
        {
            CalcualteNetAmount();
        }
        private void FirstPayTB_EditValueChanged(object sender, EventArgs e)
        {
            CalcualteNetAmount();
        }

        private void TimePerioedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AksatNumberTB.Text == 0.ToString())
            {
                TimePerioedCB.SelectedIndex = -1;
                Alert alert = new Alert("ÿßŸÑÿ±ÿ¨ÿßÿ° ÿ•ÿØÿÆÿßŸÑ ŸÇŸäŸÖÿ© ÿßŸÑŸÇÿ≥ÿ∑ ÿßŸÑŸàÿßÿ≠ÿØ", AlertForm.alertTypeEnum.Info);
                return;
            }
            else
            {
                Table = new DataTable();
                Table.Clear();
                Table.Columns.Add("ÿ™ÿßÿ±ŸäÿÆ ÿ™ÿ≥ÿØŸäÿØ ÿßŸÑÿØŸÅÿπÿ©");
                Table.Columns.Add("ŸÇŸäŸÖÿ© ÿßŸÑÿØŸÅÿπÿ©");
                gunaDataGridView1.Columns.Clear();
                DateTime date = gunaDateTimePicker1.Value;
                if (TimePerioedCB.SelectedIndex == 0)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["ÿ™ÿßÿ±ŸäÿÆ ÿ™ÿ≥ÿØŸäÿØ ÿßŸÑÿØŸÅÿπÿ©"] = date.ToString("yyyy-MM-dd");
                        row["ŸÇŸäŸÖÿ© ÿßŸÑÿØŸÅÿπÿ©"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddDays(1);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 1)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["ÿ™ÿßÿ±ŸäÿÆ ÿ™ÿ≥ÿØŸäÿØ ÿßŸÑÿØŸÅÿπÿ©"] = date.ToString("yyyy-MM-dd");
                        row["ŸÇŸäŸÖÿ© ÿßŸÑÿØŸÅÿπÿ©"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddDays(7);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 2)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["ÿ™ÿßÿ±ŸäÿÆ ÿ™ÿ≥ÿØŸäÿØ ÿßŸÑÿØŸÅÿπÿ©"] = date.ToString("yyyy-MM-dd");
                        row["ŸÇŸäŸÖÿ© ÿßŸÑÿØŸÅÿπÿ©"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddMonths(1);
                    }
                }
                if (TimePerioedCB.SelectedIndex == 3)
                {
                    for (int i = 0; i < Convert.ToInt32(AksatNumberTB.Text); i++)
                    {
                        DataRow row = Table.NewRow();
                        row["ÿ™ÿßÿ±ŸäÿÆ ÿ™ÿ≥ÿØŸäÿØ ÿßŸÑÿØŸÅÿπÿ©"] = date.ToString("yyyy-MM-dd");
                        row["ŸÇŸäŸÖÿ© ÿßŸÑÿØŸÅÿπÿ©"] = Convert.ToInt32(OneMoneyTB.Text);
                        Table.Rows.Add(row);
                        date = date.AddYears(1);
                    }
                }
                gunaDataGridView1.DataSource = Table;
                panel8.Visible = true;
                label10.Text = "ÿßŸÑŸÇŸäŸÖÿ© ÿßŸÑŸÜŸáÿßÿ¶Ÿäÿ© : " + " " + NetAmountTB.Text;
            }
        }

        private void OneMoneyTB_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                float NetAmount = float.Parse(NetAmountTB.Text);
                float OneMoney = float.Parse(OneMoneyTB.Text);
                int Aksat = Convert.ToInt32(NetAmount / OneMoney);
                AksatNumberTB.Text = Aksat.ToString();
                TimePerioedCB.Enabled = true;
            }
            catch (OverflowException)
            {
                return;
            }
        }

        private void installmentForm_Load(object sender, EventArgs e)
        {
            NetAmountTB.Text = TotalAmountTB.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAdd())
            { 
                SqlCommand command = new SqlCommand();
            command.Connection = ConnectionClass.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddInstallment_Proc";
            command.Parameters.AddWithValue("@customer_name", CustomerNameTB.Text);
            command.Parameters.AddWithValue("@bill_id", Convert.ToInt32(Bill_idTB.Text));
            command.Parameters.AddWithValue("@full_money", float.Parse(TotalAmountTB.Text));
            command.Parameters.AddWithValue("@plus_money", float.Parse(BenefitsTB.Text));
            command.Parameters.AddWithValue("@first_money", float.Parse(FirstPayTB.Text));
            command.Parameters.AddWithValue("@net_money", float.Parse(NetAmountTB.Text));
            command.Parameters.AddWithValue("@one_money", float.Parse(OneMoneyTB.Text));
            command.Parameters.AddWithValue("@time_perioed", TimePerioedCB.Text);
            command.Parameters.AddWithValue("@aksat_number", Convert.ToInt32(AksatNumberTB.Text));
            command.Parameters.AddWithValue("@first_date", gunaDateTimePicker1.Value);
            command.Parameters.AddWithValue("@last_date", gunaDataGridView1.Rows[gunaDataGridView1.Rows.Count - 1].Cells[0].Value);
            command.Parameters.AddWithValRY?@|	4⁄'3a&ú'¿-ë◊ä#ÃÇû?ûmOÉa÷?Ñ˝ Xøõ∏:ÿ¶jiØÜó·8=‚è˛8‚+¨ﬂ⁄°àS0 ŒÄIÙ◊´·D⁄kÿoÌı–w¬:∏Óäú[hÉÈlªúˆ3ëÌh˜G^ã˛êp
¨ßˇLb:‰¬πp6ú~∂üO<—æõmo•g¡%ñÜ.ÜK° ÆÄÀ†.á<»áp€éç‰ñ˙ˆh^O∑ãN™%íﬂ≥∏ ù•∂G¢ú•àY„µÙÒÔjEQG]ü™£åCU F*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJ)°RJ®î*•ÑJa?÷[âŸƒHÇ÷{a∫¡ùºN4èuâuÙ5B=l/$”ÔÇ¥”à;â6¢ñÇNòô‡Ü"(Ü>∂]H\ãa4”WF‹¿k.#fA}Qƒr“ûC¨"ñ√vHe˝ Ò%–hüDÃÑôp2ú ∑D^+rå0Zx˛x∂=ÜYˇˆÉ`˝n‚Ë`õ6®•Ω^Üw‡Ùà?˙„àØ∞~Xhá"N¡Ä8&—_C‰*ÅJ)°RÄˆzhá;a‹wEŒ-¥¡Ùà∂]N˚ô»v¥˚#ØEH8÷”&1r·\8Œ?€œ'û áhﬂÕ∂∑“éÅ≥‡K	ïRB•úp\Öp9‰A>,ÄÛÿ˛õpl$∑‘∑Ü‘g‘Åïxà‹ÿ¨ÉRsªÔòÀ´ÃÂ¬°±πÎvÒ{?.>ªû∫?UOÈ„sÏÌ‚â≥Áìü⁄3Õ‹3À\ÊöÀoç_µ•ägxÆÔòÎ7å˜Æœé_I?7~%˝˚Òæ?å∑˛8⁄⁄.ûÔ€¬“≠^)á}Òß—Oœí˛ÿ}‡ã‚`H˜ì/âfˇ„˚G=U¸Cl3Â+",Z¶§À÷)wO9F∂O˘≠ºg yﬂî\˘“îßÂ÷)_ññc÷»”éiïÁ≥^.:Ê.Y|Ãùr«1w»–1Îd}Ã›r˛‘˚d¡‘{Â‚©keŸ‘_À⁄©≤mÍ√≤kÍÚŸ©˜»7ß˛J˛sjóÏü⁄)¶=(S¶˝R~m⁄cÚ˙i˜À˚¶mîˇòˆ90≠M~8≠[j«>.≥é}JŒ?∂]˛¯ÿgdÀ±≈¡cOïW€èó◊⁄ôÁÌ	Úˆì‰ÌKÌõeπ]©„ü√È¸ı|∆…_≈K¢fJdøc∆˜;Sñ„"É˜û9Â\y î∑≈ïSŒñã¶ú#ø;%FÜ∑âøá´ß¸-‹?˘Tı”)ˇóMy5ºb Û· )øò¸D¯‡‰Ì·™)#WZ}ì«Æ¥,‚≠vÆ∂~>%rÌ¸íxï+7Ô‰á-”¬è¿&X%¶ÖÁ¡l9-‹@‹ª†	¨Ù)‚6»†=RiÔÜΩë˝Xo%fs 	zXÔÖ!ËtZßÖ£y¨ãòH¨£ØÍa+x!ô~Ï†ùF‹I¥∞p¬\»7A1Ù±ÌB‚Xã†ôæ2‚^s1ZËã"ñCêˆb±:ÿÆjiKÒf¯›…ësuµuá∏∆∫kÚ»ÁÿÓ˛kÓ˛f˛ı˝aÀ_&?bÈôº…≤mÚ*É©L≈`*S1òä¡T¶b0É©L≈`*S1òä¡˚±ﬁJÃ&Ê@Ù∞ﬁC–>Ë¥∆`*S1òä¡T¶b0É©L≈`*S1òä¡T¶b0É©L≈`*S1òä¡T¶b0É©L≈`*S1òä¡T¶b0É©L≈`*S1òä¡T¶b0É)÷°ÉÌ⁄†ñ∂Eº˛ªx0¸‚‰ëOÖºëOÖ0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êCy0‰¡êC¨C€µA-m)z√Øâõ√ÕpØõsO¥Ë∂¸C<nyjÚñÕìü¥¸nÚSñﬂO~⁄Ú¸dãxùwÌˇiÚ»H¯Ê«Ó9ﬂKGüÎ≥üA≤˜[‚áá˝E