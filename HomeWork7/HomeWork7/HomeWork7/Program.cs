using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Draw_button = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Colors = new System.Windows.Forms.ComboBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AngleRight = new System.Windows.Forms.TextBox();
            this.AngleLeft = new System.Windows.Forms.TextBox();
            this.BLRLeft = new System.Windows.Forms.TextBox();
            this.BLRRight = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Draw_button
            // 
            this.Draw_button.Font = new System.Drawing.Font("宋体", 25F);
            this.Draw_button.Location = new System.Drawing.Point(663, 9);
            this.Draw_button.Name = "Draw_button";
            this.Draw_button.Size = new System.Drawing.Size(142, 55);
            this.Draw_button.TabIndex = 0;
            this.Draw_button.Text = "Draw";
            this.Draw_button.UseVisualStyleBackColor = true;
            this.Draw_button.Click += new System.EventHandler(this.Draw_button_Click);
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(12, 70);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1610, 783);
            this.Panel.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.Depth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Color, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Colors, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Length, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.AngleRight, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.AngleLeft, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.BLRLeft, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BLRRight, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 52);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11F);
            this.label8.Location = new System.Drawing.Point(500, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Angle";
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(71, 3);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(61, 21);
            this.Depth.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(280, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branch length ratio";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("宋体", 13F);
            this.Color.Location = new System.Drawing.Point(138, 0);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(53, 18);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(221, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Right";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 11F);
            this.label7.Location = new System.Drawing.Point(500, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Angle";
            // 
            // Colors
            // 
            this.Colors.FormattingEnabled = true;
            this.Colors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Colors.Location = new System.Drawing.Point(138, 29);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(77, 20);
            this.Colors.TabIndex = 1;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(71, 29);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(61, 21);
            this.Length.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(221, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(280, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Branch length ratio";
            // 
            // AngleRight
            // 
            this.AngleRight.Location = new System.Drawing.Point(553, 29);
            this.AngleRight.Name = "AngleRight";
            this.AngleRight.Size = new System.Drawing.Size(56, 21);
            this.AngleRight.TabIndex = 16;
            // 
            // AngleLeft
            // 
            this.AngleLeft.Location = new System.Drawing.Point(553, 3);
            this.AngleLeft.Name = "AngleLeft";
            this.AngleLeft.Size = new System.Drawing.Size(56, 21);
            this.AngleLeft.TabIndex = 15;
            // 
            // BLRLeft
            // 
            this.BLRLeft.Location = new System.Drawing.Point(445, 3);
            this.BLRLeft.Name = "BLRLeft";
            this.BLRLeft.Size = new System.Drawing.Size(49, 21);
            this.BLRLeft.TabIndex = 11;
            // 
            // BLRRight
            // 
            this.BLRRight.Location = new System.Drawing.Point(445, 29);
            this.BLRRight.Name = "BLRRight";
            this.BLRRight.Size = new System.Drawing.Size(49, 21);
            this.BLRRight.TabIndex = 12;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("宋体", 17F);
            this.Label.Location = new System.Drawing.Point(1032, 28);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 23);
            this.Label.TabIndex = 20;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1619, 865);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Draw_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw_button;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AngleLeft;
        private System.Windows.Forms.TextBox BLRRight;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Colors;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox BLRLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AngleRight;
        private System.Windows.Forms.Label Label;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;

        private void Draw_button_Click(object sender, EventArgs e)
        {
            if (Length.Text == string.Empty || Depth.Text == string.Empty || BLRLeft.Text == string.Empty || BLRRight.Text == string.Empty
                || AngleLeft.Text == string.Empty || AngleRight.Text == string.Empty || Colors.Text == string.Empty)
            {
                Label.Text = "Please fill all blanks.";
                return;
            }
            int depth;
            if (!int.TryParse(Depth.Text, out depth))
            {
                Label.Text = "Invalid input.";
            }
            double length;
            if (!double.TryParse(Length.Text, out length))
            {
                Label.Text = "Invalid input";
            }
            if (graphics != null)
            {
                graphics.Clear(Color.BackColor);
            }
            graphics = Panel.CreateGraphics();

            drawCayleyTree(depth, 750, 600, length, -90);
        }
        void drawCayleyTree(int depth, double x0, double y0, double length, double angle)
        {
            if (depth == 0)
            {
                return;
            }
            double x1 = x0 + length * Math.Cos(angle * Math.PI / 180);
            double y1 = y0 + length * Math.Sin(angle * Math.PI / 180);

            drawLine(x0, y0, x1, y1);
            double blrleft, blrright, angleleft, angleright;
            if (!double.TryParse(BLRLeft.Text, out blrleft))
            {
                Label.Text = "Invalid input.";
            }
            if (!double.TryParse(BLRRight.Text, out blrright))
            {
                Label.Text = "Invalid input.";
            }
            if (!double.TryParse(AngleLeft.Text, out angleleft))
            {
                Label.Text = "Invalid input.";
            }
            if (!double.TryParse(AngleRight.Text, out angleright))
            {
                Label.Text = "Invalid input";
            }
            Label.Text = "";
            drawCayleyTree(depth - 1, x1, y1, blrleft * length, angle + angleleft);
            drawCayleyTree(depth - 1, x1, y1, blrright * length, angle - angleright);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (Colors.Text)
            {
                case "Red":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Green":
                    graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }
        }


    }
}
