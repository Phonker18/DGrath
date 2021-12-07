
namespace DGrath
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbValue = new System.Windows.Forms.TextBox();
            this.buttonAdj = new System.Windows.Forms.Button();
            this.MGridView = new System.Windows.Forms.DataGridView();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDist = new System.Windows.Forms.Button();
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbRes = new System.Windows.Forms.TextBox();
            this.btnMinV = new System.Windows.Forms.Button();
            this.btnDFC = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.txbStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(120, 68);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(46, 20);
            this.txbValue.TabIndex = 10;
            this.txbValue.Text = "1";
            // 
            // buttonAdj
            // 
            this.buttonAdj.Location = new System.Drawing.Point(74, 3);
            this.buttonAdj.Name = "buttonAdj";
            this.buttonAdj.Size = new System.Drawing.Size(92, 24);
            this.buttonAdj.TabIndex = 7;
            this.buttonAdj.Text = "матрица весов";
            this.buttonAdj.UseVisualStyleBackColor = true;
            this.buttonAdj.Click += new System.EventHandler(this.buttonAdj_Click);
            // 
            // MGridView
            // 
            this.MGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MGridView.Location = new System.Drawing.Point(3, 30);
            this.MGridView.Name = "MGridView";
            this.MGridView.Size = new System.Drawing.Size(254, 203);
            this.MGridView.TabIndex = 11;
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Location = new System.Drawing.Point(3, 134);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(108, 34);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.Text = "Очистить граф";
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(3, 94);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 34);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить элемент";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.Location = new System.Drawing.Point(3, 52);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(108, 36);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.Text = "Соединить ";
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Location = new System.Drawing.Point(3, 3);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(108, 43);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.Text = "Добавить вершину";
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheet.Location = new System.Drawing.Point(12, 50);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(634, 415);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDist);
            this.panel1.Controls.Add(this.DGridView);
            this.panel1.Controls.Add(this.buttonAdj);
            this.panel1.Controls.Add(this.MGridView);
            this.panel1.Location = new System.Drawing.Point(655, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 238);
            this.panel1.TabIndex = 12;
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(333, 4);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(139, 23);
            this.btnDist.TabIndex = 13;
            this.btnDist.Text = "матрица кр. расстояний";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(263, 30);
            this.DGridView.Name = "DGridView";
            this.DGridView.Size = new System.Drawing.Size(286, 203);
            this.DGridView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Вес";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbValue);
            this.panel2.Controls.Add(this.deleteALLButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.drawEdgeButton);
            this.panel2.Controls.Add(this.drawVertexButton);
            this.panel2.Location = new System.Drawing.Point(655, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 171);
            this.panel2.TabIndex = 14;
            // 
            // txbRes
            // 
            this.txbRes.Location = new System.Drawing.Point(12, 484);
            this.txbRes.Name = "txbRes";
            this.txbRes.Size = new System.Drawing.Size(634, 20);
            this.txbRes.TabIndex = 15;
            // 
            // btnMinV
            // 
            this.btnMinV.Location = new System.Drawing.Point(5, 112);
            this.btnMinV.Name = "btnMinV";
            this.btnMinV.Size = new System.Drawing.Size(124, 38);
            this.btnMinV.TabIndex = 17;
            this.btnMinV.Text = "Город с мин. суммой кр. расстояний";
            this.btnMinV.UseVisualStyleBackColor = true;
            this.btnMinV.Click += new System.EventHandler(this.btnMinV_Click);
            // 
            // btnDFC
            // 
            this.btnDFC.Location = new System.Drawing.Point(5, 21);
            this.btnDFC.Name = "btnDFC";
            this.btnDFC.Size = new System.Drawing.Size(124, 42);
            this.btnDFC.TabIndex = 18;
            this.btnDFC.Text = "поиск в глубину";
            this.btnDFC.UseVisualStyleBackColor = true;
            this.btnDFC.Click += new System.EventHandler(this.btnDFC_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(5, 69);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(124, 37);
            this.btnCycle.TabIndex = 20;
            this.btnCycle.Text = "поиск эйлерова цикла";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // txbStart
            // 
            this.txbStart.Location = new System.Drawing.Point(166, 37);
            this.txbStart.Name = "txbStart";
            this.txbStart.Size = new System.Drawing.Size(44, 20);
            this.txbStart.TabIndex = 21;
            this.txbStart.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "начальная вершина";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbStart);
            this.panel3.Controls.Add(this.btnCycle);
            this.panel3.Controls.Add(this.btnDFC);
            this.panel3.Controls.Add(this.btnMinV);
            this.panel3.Location = new System.Drawing.Point(864, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 170);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1192, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txbRes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sheet);
            this.Name = "Form1";
            this.Text = "vscode.ru";
            ((System.ComponentModel.ISupportInitialize)(this.MGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button buttonAdj;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.DataGridView MGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbRes;
        private System.Windows.Forms.Button btnMinV;
        private System.Windows.Forms.Button btnDFC;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.TextBox txbStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}

