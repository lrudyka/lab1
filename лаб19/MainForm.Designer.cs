namespace лаб19
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numBirthYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numDepartment = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО пациента";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(53, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(196, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Год рождения";
            // 
            // numBirthYear
            // 
            this.numBirthYear.Location = new System.Drawing.Point(93, 89);
            this.numBirthYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numBirthYear.Name = "numBirthYear";
            this.numBirthYear.Size = new System.Drawing.Size(120, 26);
            this.numBirthYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата поступления";
            // 
            // dtpAdmissionDate
            // 
            this.dtpAdmissionDate.Location = new System.Drawing.Point(53, 148);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.Size = new System.Drawing.Size(196, 26);
            this.dtpAdmissionDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Предварительный диагноз";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(53, 209);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(196, 26);
            this.txtDiagnosis.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "№ отделения";
            // 
            // numDepartment
            // 
            this.numDepartment.Location = new System.Drawing.Point(93, 270);
            this.numDepartment.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numDepartment.Name = "numDepartment";
            this.numDepartment.Size = new System.Drawing.Size(120, 26);
            this.numDepartment.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 47);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(113, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 47);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(217, 315);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(84, 47);
            this.btnShowData.TabIndex = 4;
            this.btnShowData.Text = "Показать данные";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 386);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpAdmissionDate);
            this.Controls.Add(this.numDepartment);
            this.Controls.Add(this.numBirthYear);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Работа с бинарным файлом";
            ((System.ComponentModel.ISupportInitialize)(this.numBirthYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBirthYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowData;
    }
}