
namespace ParabolaCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Calculate = new System.Windows.Forms.CheckBox();
            this.cb_Vertex = new System.Windows.Forms.CheckBox();
            this.cb_Value = new System.Windows.Forms.CheckBox();
            this.cb_Decomp = new System.Windows.Forms.CheckBox();
            this.cb_Deriv = new System.Windows.Forms.CheckBox();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уведіть коефіцієнти тричлена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "a = ";
            // 
            // tb_A
            // 
            this.tb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_A.Location = new System.Drawing.Point(389, 26);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(64, 26);
            this.tb_A.TabIndex = 2;
            this.tb_A.Text = "1";
            this.tb_A.Validating += new System.ComponentModel.CancelEventHandler(this.tb_A_Validating);
            // 
            // tb_B
            // 
            this.tb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_B.Location = new System.Drawing.Point(523, 26);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(64, 26);
            this.tb_B.TabIndex = 4;
            this.tb_B.Leave += new System.EventHandler(this.tb_B_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(488, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "b = ";
            // 
            // tb_C
            // 
            this.tb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_C.Location = new System.Drawing.Point(660, 25);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(64, 26);
            this.tb_C.TabIndex = 6;
            this.tb_C.Leave += new System.EventHandler(this.tb_C_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(625, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "c = ";
            // 
            // cb_Calculate
            // 
            this.cb_Calculate.AutoSize = true;
            this.cb_Calculate.Location = new System.Drawing.Point(34, 95);
            this.cb_Calculate.Name = "cb_Calculate";
            this.cb_Calculate.Size = new System.Drawing.Size(171, 21);
            this.cb_Calculate.TabIndex = 7;
            this.cb_Calculate.Text = "Корені рівняння y = 0";
            this.cb_Calculate.UseVisualStyleBackColor = true;
            // 
            // cb_Vertex
            // 
            this.cb_Vertex.AutoSize = true;
            this.cb_Vertex.Location = new System.Drawing.Point(34, 122);
            this.cb_Vertex.Name = "cb_Vertex";
            this.cb_Vertex.Size = new System.Drawing.Size(172, 21);
            this.cb_Vertex.TabIndex = 8;
            this.cb_Vertex.Text = "Координати вершини";
            this.cb_Vertex.UseVisualStyleBackColor = true;
            // 
            // cb_Value
            // 
            this.cb_Value.AutoSize = true;
            this.cb_Value.Location = new System.Drawing.Point(34, 149);
            this.cb_Value.Name = "cb_Value";
            this.cb_Value.Size = new System.Drawing.Size(211, 21);
            this.cb_Value.TabIndex = 9;
            this.cb_Value.Text = "Значення тричлена в точці";
            this.cb_Value.UseVisualStyleBackColor = true;
            this.cb_Value.CheckedChanged += new System.EventHandler(this.cb_Value_CheckedChanged);
            // 
            // cb_Decomp
            // 
            this.cb_Decomp.AutoSize = true;
            this.cb_Decomp.Location = new System.Drawing.Point(34, 176);
            this.cb_Decomp.Name = "cb_Decomp";
            this.cb_Decomp.Size = new System.Drawing.Size(219, 21);
            this.cb_Decomp.TabIndex = 10;
            this.cb_Decomp.Text = "Розклад на прості множники";
            this.cb_Decomp.UseVisualStyleBackColor = true;
            // 
            // cb_Deriv
            // 
            this.cb_Deriv.AutoSize = true;
            this.cb_Deriv.Location = new System.Drawing.Point(34, 203);
            this.cb_Deriv.Name = "cb_Deriv";
            this.cb_Deriv.Size = new System.Drawing.Size(85, 21);
            this.cb_Deriv.TabIndex = 11;
            this.cb_Deriv.Text = "Похідна ";
            this.cb_Deriv.UseVisualStyleBackColor = true;
            // 
            // tb_Result
            // 
            this.tb_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Result.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Result.Location = new System.Drawing.Point(323, 73);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(465, 162);
            this.tb_Result.TabIndex = 12;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Calc.Location = new System.Drawing.Point(389, 257);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(105, 30);
            this.btn_Calc.TabIndex = 13;
            this.btn_Calc.Text = "Обчислити";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(500, 257);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 30);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Очистити";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Quit.Location = new System.Drawing.Point(611, 257);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(105, 30);
            this.btn_Quit.TabIndex = 15;
            this.btn_Quit.Text = "Завершити";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // tb_X
            // 
            this.tb_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_X.Location = new System.Drawing.Point(242, 144);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(64, 26);
            this.tb_X.TabIndex = 16;
            this.tb_X.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_Calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Quit;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.cb_Deriv);
            this.Controls.Add(this.cb_Decomp);
            this.Controls.Add(this.cb_Value);
            this.Controls.Add(this.cb_Vertex);
            this.Controls.Add(this.cb_Calculate);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Обчислення для квадратного тричлена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_Calculate;
        private System.Windows.Forms.CheckBox cb_Vertex;
        private System.Windows.Forms.CheckBox cb_Value;
        private System.Windows.Forms.CheckBox cb_Decomp;
        private System.Windows.Forms.CheckBox cb_Deriv;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.TextBox tb_X;
    }
}

