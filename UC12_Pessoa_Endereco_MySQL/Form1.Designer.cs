namespace UC12_Pessoa_Endereco_MySQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxSOBRENOME = new System.Windows.Forms.TextBox();
            this.textBoxNOMESOCIAL = new System.Windows.Forms.TextBox();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.dateTimePickerNASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.comboBoxETNIA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonMASCULINO = new System.Windows.Forms.RadioButton();
            this.radioButtonFEMININO = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.comboBoxESTADO = new System.Windows.Forms.ComboBox();
            this.textBoxBAIRRO = new System.Windows.Forms.TextBox();
            this.textBoxCIDADE = new System.Windows.Forms.TextBox();
            this.textBoxLOGRADOURO = new System.Windows.Forms.TextBox();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(13, 55);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(232, 20);
            this.textBoxNOME.TabIndex = 0;
            // 
            // textBoxSOBRENOME
            // 
            this.textBoxSOBRENOME.Location = new System.Drawing.Point(13, 94);
            this.textBoxSOBRENOME.Name = "textBoxSOBRENOME";
            this.textBoxSOBRENOME.Size = new System.Drawing.Size(232, 20);
            this.textBoxSOBRENOME.TabIndex = 1;
            // 
            // textBoxNOMESOCIAL
            // 
            this.textBoxNOMESOCIAL.Location = new System.Drawing.Point(12, 133);
            this.textBoxNOMESOCIAL.Name = "textBoxNOMESOCIAL";
            this.textBoxNOMESOCIAL.Size = new System.Drawing.Size(232, 20);
            this.textBoxNOMESOCIAL.TabIndex = 2;
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(13, 188);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(186, 20);
            this.textBoxRG.TabIndex = 3;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(13, 228);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(186, 20);
            this.textBoxCPF.TabIndex = 4;
            // 
            // dateTimePickerNASCIMENTO
            // 
            this.dateTimePickerNASCIMENTO.Location = new System.Drawing.Point(342, 55);
            this.dateTimePickerNASCIMENTO.Name = "dateTimePickerNASCIMENTO";
            this.dateTimePickerNASCIMENTO.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNASCIMENTO.TabIndex = 5;
            // 
            // comboBoxETNIA
            // 
            this.comboBoxETNIA.FormattingEnabled = true;
            this.comboBoxETNIA.Items.AddRange(new object[] {
            "Branco",
            "Afrodescendente",
            "Pardo",
            "Indígena"});
            this.comboBoxETNIA.Location = new System.Drawing.Point(342, 94);
            this.comboBoxETNIA.Name = "comboBoxETNIA";
            this.comboBoxETNIA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxETNIA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Etnia:";
            // 
            // radioButtonMASCULINO
            // 
            this.radioButtonMASCULINO.AutoSize = true;
            this.radioButtonMASCULINO.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMASCULINO.Name = "radioButtonMASCULINO";
            this.radioButtonMASCULINO.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMASCULINO.TabIndex = 7;
            this.radioButtonMASCULINO.TabStop = true;
            this.radioButtonMASCULINO.Text = "Masculino";
            this.radioButtonMASCULINO.UseVisualStyleBackColor = true;
            // 
            // radioButtonFEMININO
            // 
            this.radioButtonFEMININO.AutoSize = true;
            this.radioButtonFEMININO.Location = new System.Drawing.Point(105, 3);
            this.radioButtonFEMININO.Name = "radioButtonFEMININO";
            this.radioButtonFEMININO.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFEMININO.TabIndex = 8;
            this.radioButtonFEMININO.TabStop = true;
            this.radioButtonFEMININO.Text = "Feminino";
            this.radioButtonFEMININO.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonFEMININO);
            this.panel1.Controls.Add(this.radioButtonMASCULINO);
            this.panel1.Location = new System.Drawing.Point(342, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 29);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gênero:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBoxUF);
            this.panel2.Controls.Add(this.comboBoxESTADO);
            this.panel2.Controls.Add(this.textBoxBAIRRO);
            this.panel2.Controls.Add(this.textBoxCIDADE);
            this.panel2.Controls.Add(this.textBoxLOGRADOURO);
            this.panel2.Location = new System.Drawing.Point(245, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 166);
            this.panel2.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Logradouro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "UF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cidade:";
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "11\tRondônia\tRO",
            "12\tAcre\tAC",
            "13\tAmazonas\tAM",
            "14\tRoraima\tRR",
            "15\tPará\tPA",
            "16\tAmapá\tAP",
            "17\tTocantins\tTO",
            "21\tMaranhão\tMA",
            "22\tPiauí\tPI",
            "23\tCeará\tCE",
            "24\tRio Grande do Norte\tRN",
            "25\tParaíba\tPB",
            "26\tPernambuco\tPE",
            "27\tAlagoas\tAL",
            "28\tSergipe\tSE",
            "29\tBahia\tBA",
            "31\tMinas Gerais\tMG",
            "32\tEspírito Santo\tES",
            "33\tRio de Janeiro\tRJ",
            "35\tSão Paulo\tSP",
            "41\tParaná\tPR",
            "42\tSanta Catarina\tSC",
            "43\tRio Grande do Sul (*)\tRS",
            "50\tMato Grosso do Sul\tMS",
            "51\tMato Grosso\tMT",
            "52\tGoiás\tGO",
            "53\tDistrito Federal\tDF"});
            this.comboBoxUF.Location = new System.Drawing.Point(168, 132);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUF.TabIndex = 4;
            // 
            // comboBoxESTADO
            // 
            this.comboBoxESTADO.FormattingEnabled = true;
            this.comboBoxESTADO.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.comboBoxESTADO.Location = new System.Drawing.Point(13, 132);
            this.comboBoxESTADO.Name = "comboBoxESTADO";
            this.comboBoxESTADO.Size = new System.Drawing.Size(121, 21);
            this.comboBoxESTADO.TabIndex = 3;
            // 
            // textBoxBAIRRO
            // 
            this.textBoxBAIRRO.Location = new System.Drawing.Point(14, 93);
            this.textBoxBAIRRO.Name = "textBoxBAIRRO";
            this.textBoxBAIRRO.Size = new System.Drawing.Size(276, 20);
            this.textBoxBAIRRO.TabIndex = 2;
            // 
            // textBoxCIDADE
            // 
            this.textBoxCIDADE.Location = new System.Drawing.Point(14, 54);
            this.textBoxCIDADE.Name = "textBoxCIDADE";
            this.textBoxCIDADE.Size = new System.Drawing.Size(276, 20);
            this.textBoxCIDADE.TabIndex = 1;
            // 
            // textBoxLOGRADOURO
            // 
            this.textBoxLOGRADOURO.Location = new System.Drawing.Point(14, 15);
            this.textBoxLOGRADOURO.Name = "textBoxLOGRADOURO";
            this.textBoxLOGRADOURO.Size = new System.Drawing.Size(276, 20);
            this.textBoxLOGRADOURO.TabIndex = 0;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(12, 254);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(186, 23);
            this.buttonCADASTRAR.TabIndex = 19;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 351);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxETNIA);
            this.Controls.Add(this.dateTimePickerNASCIMENTO);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.textBoxNOMESOCIAL);
            this.Controls.Add(this.textBoxSOBRENOME);
            this.Controls.Add(this.textBoxNOME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxSOBRENOME;
        private System.Windows.Forms.TextBox textBoxNOMESOCIAL;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.DateTimePicker dateTimePickerNASCIMENTO;
        private System.Windows.Forms.ComboBox comboBoxETNIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonMASCULINO;
        private System.Windows.Forms.RadioButton radioButtonFEMININO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.ComboBox comboBoxESTADO;
        private System.Windows.Forms.TextBox textBoxBAIRRO;
        private System.Windows.Forms.TextBox textBoxCIDADE;
        private System.Windows.Forms.TextBox textBoxLOGRADOURO;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}

