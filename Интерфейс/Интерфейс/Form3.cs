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

namespace Интерфейс
{

    public partial class Form3 : Form
    {
        //SqlConnection SomeConnection = new SqlConnection("Data Source=C41204;Initial Catalog=Т_К;Integrated Security=True");
        SqlConnection SomeConnection = new SqlConnection("Data Source=HOME-PC; Initial Catalog=T_K; Integrated Security=True");
        string ZnachenieVvedennoePolzovatelem;
        //public void Isp_Knopki()
        //{
        //    if (MyClass.Zakritie)
        //    {
        //        switch (MyClass.Opredelenie_Knopki)
        //        {
        //            case 1:
        //                Procedura_1("proc1", MyClass.Znachenie);
        //                MyClass.Opredelenie_Knopki = 0;
        //                label1.Text = (MyClass.Znachenie);
        //                break;
        //        }
        //    }
        //}


        public Form3()
        {
            InitializeComponent();
            ProverkaDostupa();
        }

        new public void Load()
        {
            SomeConnection.Open();
        }

        public void Open_1_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand( query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_2_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование должности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Оклад" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Обязанности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Требования" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_3_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_4_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Технические характеристики" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_5_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля для транспортировки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_6_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_7_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[10]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Open_8_Tab(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Zapros1(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование должности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Оклад" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Обязанности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Требования" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[12]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Zapros2(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля для транспортировки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида автомобиля" });


            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Zapros3(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля для транспортировки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида груза" });


            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[5].ToString();
                data[data.Count - 1][7] = reader[5].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Zapros4(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Технические характеристики" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });


            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[22]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Zapros5(string query)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });


            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[31]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();

            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_2(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie2", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование видов грузов" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля для транспортировки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида грузов" });


            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_1(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie1", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование должности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Оклад" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Обязанности" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Требования" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[12]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_3(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie3", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Технические характеристики" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание марки автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Описание вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[22]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_4(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie4", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[31]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_5(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie5", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[31]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_6(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie6", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[31]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        public void Procedura_7(string query, string Prin_Znach)
        {
            dataGridView1.Columns.Clear();
            Load();
            SqlCommand command = new SqlCommand(query, SomeConnection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Znachenie7", SqlDbType.VarChar).Value = Prin_Znach;
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Заказчик" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Откуда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Куда" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата отправления" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата прибытия" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Цена" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка об оплате" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Отметка о возвращении" });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код марки" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида автомобиля" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника водителя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код сотрудника механика" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Регистрационный номер" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер кузова" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Номер двигателя" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Год выпуска" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Дата последнего ТО" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Наименование груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код вида груза" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Срок хранения" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Особенности груза" });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ФИО" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Возраст" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Пол" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Адресс" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Телефон" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Паспортные данные" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Код должности" });

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[31]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
                data[data.Count - 1][14] = reader[14].ToString();
                data[data.Count - 1][15] = reader[15].ToString();
                data[data.Count - 1][16] = reader[16].ToString();
                data[data.Count - 1][17] = reader[17].ToString();
                data[data.Count - 1][18] = reader[18].ToString();
                data[data.Count - 1][19] = reader[19].ToString();
                data[data.Count - 1][20] = reader[20].ToString();
                data[data.Count - 1][21] = reader[21].ToString();
                data[data.Count - 1][22] = reader[22].ToString();
                data[data.Count - 1][23] = reader[23].ToString();
                data[data.Count - 1][24] = reader[24].ToString();
                data[data.Count - 1][25] = reader[25].ToString();
                data[data.Count - 1][26] = reader[26].ToString();
                data[data.Count - 1][27] = reader[27].ToString();
                data[data.Count - 1][28] = reader[28].ToString();
                data[data.Count - 1][29] = reader[29].ToString();
                data[data.Count - 1][30] = reader[30].ToString();
            }
            reader.Close();
            SomeConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Open_1_Tab("SELECT * FROM Sotrudnika");
           MyClass.NomerKnopki = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Open_2_Tab("SELECT * FROM Dolzjnosti");
            MyClass.NomerKnopki = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Open_3_Tab("SELECT * FROM Vidi_Avto");
            MyClass.NomerKnopki = 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Open_4_Tab("SELECT * FROM Marki_Avto");
            MyClass.NomerKnopki = 11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Open_5_Tab("SELECT * FROM Vidi_Gruzov");
            MyClass.NomerKnopki = 12;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Open_6_Tab("SELECT * FROM Gruzi");
            MyClass.NomerKnopki = 13;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Open_7_Tab("SELECT * FROM Avto");
            MyClass.NomerKnopki = 14;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Open_8_Tab("SELECT * FROM Reysi");
            MyClass.NomerKnopki = 15;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Zapros1("zapros1");
            MyClass.NomerKnopki = 16;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Zapros2("zapros2");
            MyClass.NomerKnopki = 17;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Zapros3("zapros3");
            MyClass.NomerKnopki = 18;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Zapros4("zapros4");
            MyClass.NomerKnopki = 19;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Zapros5("zapros5");
            MyClass.NomerKnopki = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 1;
            panel1.Visible = true;
            //Procedura_2("proc2", "Dolzjnost1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 2;
            panel1.Visible = true;
            //Procedura_2("proc2", "Naimenovanie1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 3;
            panel1.Visible = true;
            //Procedura_3("proc3", "Naimenovanie1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 4;
            panel1.Visible = true;
            //Procedura_4("proc4", "Naimenovanie1");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 5;
            panel1.Visible = true;
            //Procedura_5("proc5", "Zakazchik1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 6;
            panel1.Visible = true;
            //Procedura_6("proc6", "Otmetka_ob_oplate1");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyClass.NomerKnopki = 7;
            panel1.Visible = true;
            //Procedura_7("proc7", "Otmetka_o_vozvrachenie1");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ZnachenieVvedennoePolzovatelem = textBox1.Text;
            panel1.Visible = false;
            switch (MyClass.NomerKnopki)
            {
                case 1:
                    {
                        Procedura_1("proc1", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 2:
                    {
                        Procedura_2("proc2", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 3:
                    {
                        Procedura_3("proc3", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 4:
                    {
                        Procedura_4("proc4", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 5:
                    {
                        Procedura_5("proc5", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 6:
                    {
                        Procedura_6("proc6", ZnachenieVvedennoePolzovatelem);
                        break; }
                case 7:
                    {
                        Procedura_7("proc7", ZnachenieVvedennoePolzovatelem);
                        break; }
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        public void ProverkaDostupa()
        {
            if (MyClass.Dostup == 1)
            { groupBox5.Visible = false; }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();

            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if ((MyClass.NomerKnopki >= 8) && (MyClass.NomerKnopki <= 15))
            {
                Form Form6 = new Form6();
                Form6.Show();

               // this.Hide();
            }
            else
            { MessageBox.Show("Таблица не выбрана"); }
        }
    }
}
