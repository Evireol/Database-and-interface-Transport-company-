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
using System.Data.Common;

namespace Интерфейс
{
    public partial class Form6 : Form
    {
        //SqlConnection SomeConnection = new SqlConnection("Data Source=C41204;Initial Catalog=Т_К;Integrated Security=True");
        SqlConnection SomeConnection = new SqlConnection("Data Source = SYS-X; Initial Catalog = Т_К; Integrated Security = True");
        string VvodPolzovatelaND, VvodPolzovatelaOklad, VvodPolzovatelaObjazanosti, VvodPolzovatelaTrebovania;
        string VvodKoda;

        public Form6()
        {
            InitializeComponent();

            Form Form3 = new Form3();
            switch (MyClass.NomerKnopki)
            {
                case 8:
                    {
                    label1.Text = "Код сотрудника:";
                    label2.Text = "ФИО:";
                    label3.Text = "Возраст:";
                    label4.Text = "Пол:";
                    label5.Text = "Адрес:";
                    label6.Text = "Телефон:";
                    label7.Text = "Паспортные данные:";
                    label8.Text = "Код должности:";
                        this.Height = 391;
                        break; }
                case 9:
                    {
                        label1.Text = "Код должности";
                        label2.Text = "Наименование должности";
                        label3.Text = "Оклад:";
                        label4.Text = "Обязанности:";
                        label5.Text = "Требования:";
                        this.Height = 284;
                        break; }
                case 10:
                    {
                        label1.Text = "Код вида автомобиля:";
                        label2.Text = "Наименование:";
                        label3.Text = "Описание:";
                        this.Height = 207;
                        break; }
                case 11:
                    label1.Text = "Код марки:";
                    label2.Text = "Наименование:";
                    label3.Text = "Технические характеристики:";
                    label4.Text = "Описание:";
                    this.Height = 243;
                    { break; }
                case 12:
                    {
                        label1.Text = "Код вида груза:";
                        label2.Text = "Наименование:";
                        label3.Text = "Код вида автомобиля для транспортировки:";
                        label4.Text = "Описание:";
                        this.Height = 243;
                        break; }
                case 13:
                    {
                        label1.Text = "Код груза:";
                        label2.Text = "Наименование:";
                        label3.Text = "Код вида груза:";
                        label4.Text = "Срок хранения:";
                        label5.Text = "Особенности:";
                        this.Height = 279;
                        break; }
                case 14:
                    {
                        label1.Text = "Код автомобиля:";
                        label2.Text = "Код марки:";
                        label3.Text = "Код вида автомобиля:";
                        label4.Text = "Код сотрудника водителя:";
                        label5.Text = "Код сотрудника механика:";
                        label6.Text = "Регистрационный номер:";
                        label7.Text = "Номер кузова:";
                        label8.Text = "Номер двигателя:";
                        label9.Text = "Год выпуска:";
                        label10.Text = "Дата последнего ТО:";
                        this.Height = 467;
                        break; }
                case 15:
                    {
                        label10.Text = "Код автомобиля:";
                        label10.Text = "Код груза:";
                        label10.Text = "Код сотрудника:";
                        label10.Text = "Заказчик:";
                        label10.Text = "Откуда:";
                        label10.Text = "Rуда:";
                        label10.Text = "Дата отправления:";
                        label10.Text = "Дата прибытия:";
                        label10.Text = "Цена:";
                        label10.Text = "Отметка об оплате:";
                        label10.Text = "Отметка о возвращении:";
                        this.Height = 506;
                        break;
                    }


            }
        }

        public void Laod2()
        {
            SqlCommand command = new SqlCommand("EditDolzjnosti", SomeConnection);
            SomeConnection.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@VvodPolzovatela",SqlDbType.NVarChar).Value = VvodPolzovatelaND;
            command.Parameters.Add("@Kod", SqlDbType.Int).Value = VvodKoda;
            command.Parameters.Add("@Oklad", SqlDbType.Int).Value = VvodPolzovatelaOklad;
            command.Parameters.Add("@Objazanosti", SqlDbType.NVarChar).Value = VvodPolzovatelaObjazanosti;
            command.Parameters.Add("@Trebovania", SqlDbType.NVarChar).Value = VvodPolzovatelaTrebovania;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                return;
            }
            reader.Close();
            SomeConnection.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VvodPolzovatelaND = textBox2.Text;
            VvodKoda = textBox1.Text;
            VvodPolzovatelaOklad = textBox3.Text;
            VvodPolzovatelaObjazanosti = textBox4.Text;
            VvodPolzovatelaTrebovania = textBox5.Text;
            if (VvodKoda != "")
            {
                if ((VvodPolzovatelaND != "")||(VvodPolzovatelaOklad !="") || (VvodPolzovatelaObjazanosti != "") || (VvodPolzovatelaTrebovania != ""))
                {
                    try
                    {
                        Laod2();
                }
                    catch
                {
                    MessageBox.Show("Не корректный тип у данных");
                }
            }
                else
                { MessageBox.Show("Все поля обязательны для заполнения"); }
            }
            else
            { MessageBox.Show("Не выбрана строка"); }

         //   this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form Form3 = new Form3();
            //Form3.Show();

            this.Hide();
        }
    }
}
