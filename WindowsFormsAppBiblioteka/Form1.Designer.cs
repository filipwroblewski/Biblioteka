namespace WindowsFormsAppBiblioteka
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.outputInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputDataWydania = new System.Windows.Forms.TextBox();
            this.inputTytul = new System.Windows.Forms.TextBox();
            this.addBook = new System.Windows.Forms.Button();
            this.listOsoby = new System.Windows.Forms.ListBox();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadDefaultData = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.spisKsiazek = new System.Windows.Forms.ListBox();
            this.addCzytelnik = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listCzytelnicy = new System.Windows.Forms.ListBox();
            this.addCzytelnikByName = new System.Windows.Forms.Button();
            this.showReadBooks = new System.Windows.Forms.Button();
            this.addRecenzent = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listRecenzenci = new System.Windows.Forms.ListBox();
            this.showBooksGrade = new System.Windows.Forms.Button();
            this.osobaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.osobaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // inputName
            // 
            resources.ApplyResources(this.inputName, "inputName");
            this.inputName.Name = "inputName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inputSurname
            // 
            resources.ApplyResources(this.inputSurname, "inputSurname");
            this.inputSurname.Name = "inputSurname";
            // 
            // inputAge
            // 
            resources.ApplyResources(this.inputAge, "inputAge");
            this.inputAge.Name = "inputAge";
            // 
            // outputInfo
            // 
            resources.ApplyResources(this.outputInfo, "outputInfo");
            this.outputInfo.Name = "outputInfo";
            this.outputInfo.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // inputDataWydania
            // 
            resources.ApplyResources(this.inputDataWydania, "inputDataWydania");
            this.inputDataWydania.Name = "inputDataWydania";
            // 
            // inputTytul
            // 
            resources.ApplyResources(this.inputTytul, "inputTytul");
            this.inputTytul.Name = "inputTytul";
            this.inputTytul.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addBook
            // 
            resources.ApplyResources(this.addBook, "addBook");
            this.addBook.Name = "addBook";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // listOsoby
            // 
            this.listOsoby.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.osobaBindingSource, "Imie", true));
            this.listOsoby.FormattingEnabled = true;
            resources.ApplyResources(this.listOsoby, "listOsoby");
            this.listOsoby.Name = "listOsoby";
            this.listOsoby.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataSource = typeof(WindowsFormsAppBiblioteka.Osoba);
            // 
            // loadDefaultData
            // 
            resources.ApplyResources(this.loadDefaultData, "loadDefaultData");
            this.loadDefaultData.Name = "loadDefaultData";
            this.loadDefaultData.UseVisualStyleBackColor = true;
            this.loadDefaultData.Click += new System.EventHandler(this.loadDefaultData_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // spisKsiazek
            // 
            this.spisKsiazek.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.osobaBindingSource, "Imie", true));
            this.spisKsiazek.FormattingEnabled = true;
            resources.ApplyResources(this.spisKsiazek, "spisKsiazek");
            this.spisKsiazek.Name = "spisKsiazek";
            this.spisKsiazek.SelectedIndexChanged += new System.EventHandler(this.spisOsob_SelectedIndexChanged);
            // 
            // addCzytelnik
            // 
            resources.ApplyResources(this.addCzytelnik, "addCzytelnik");
            this.addCzytelnik.Name = "addCzytelnik";
            this.addCzytelnik.UseVisualStyleBackColor = true;
            this.addCzytelnik.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // listCzytelnicy
            // 
            this.listCzytelnicy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.osobaBindingSource, "Imie", true));
            this.listCzytelnicy.FormattingEnabled = true;
            resources.ApplyResources(this.listCzytelnicy, "listCzytelnicy");
            this.listCzytelnicy.Name = "listCzytelnicy";
            // 
            // addCzytelnikByName
            // 
            resources.ApplyResources(this.addCzytelnikByName, "addCzytelnikByName");
            this.addCzytelnikByName.Name = "addCzytelnikByName";
            this.addCzytelnikByName.UseVisualStyleBackColor = true;
            this.addCzytelnikByName.Click += new System.EventHandler(this.addCzytelnikByName_Click);
            // 
            // showReadBooks
            // 
            resources.ApplyResources(this.showReadBooks, "showReadBooks");
            this.showReadBooks.Name = "showReadBooks";
            this.showReadBooks.UseVisualStyleBackColor = true;
            this.showReadBooks.Click += new System.EventHandler(this.showReadBooks_Click);
            // 
            // addRecenzent
            // 
            resources.ApplyResources(this.addRecenzent, "addRecenzent");
            this.addRecenzent.Name = "addRecenzent";
            this.addRecenzent.UseVisualStyleBackColor = true;
            this.addRecenzent.Click += new System.EventHandler(this.addRecenzent_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // listRecenzenci
            // 
            this.listRecenzenci.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.osobaBindingSource, "Imie", true));
            this.listRecenzenci.FormattingEnabled = true;
            resources.ApplyResources(this.listRecenzenci, "listRecenzenci");
            this.listRecenzenci.Name = "listRecenzenci";
            // 
            // showBooksGrade
            // 
            resources.ApplyResources(this.showBooksGrade, "showBooksGrade");
            this.showBooksGrade.Name = "showBooksGrade";
            this.showBooksGrade.UseVisualStyleBackColor = true;
            this.showBooksGrade.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // osobaBindingSource1
            // 
            this.osobaBindingSource1.DataSource = typeof(WindowsFormsAppBiblioteka.Osoba);
            // 
            // osobaBindingSource2
            // 
            this.osobaBindingSource2.DataSource = typeof(WindowsFormsAppBiblioteka.Osoba);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showBooksGrade);
            this.Controls.Add(this.listRecenzenci);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addRecenzent);
            this.Controls.Add(this.showReadBooks);
            this.Controls.Add(this.addCzytelnikByName);
            this.Controls.Add(this.listCzytelnicy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addCzytelnik);
            this.Controls.Add(this.spisKsiazek);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.loadDefaultData);
            this.Controls.Add(this.listOsoby);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.inputTytul);
            this.Controls.Add(this.inputDataWydania);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputInfo);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Label outputInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputDataWydania;
        private System.Windows.Forms.TextBox inputTytul;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.ListBox listOsoby;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private System.Windows.Forms.Button loadDefaultData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox spisKsiazek;
        private System.Windows.Forms.Button addCzytelnik;
        private System.Windows.Forms.BindingSource osobaBindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listCzytelnicy;
        private System.Windows.Forms.BindingSource osobaBindingSource2;
        private System.Windows.Forms.Button addCzytelnikByName;
        private System.Windows.Forms.Button showReadBooks;
        private System.Windows.Forms.Button addRecenzent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listRecenzenci;
        private System.Windows.Forms.Button showBooksGrade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

