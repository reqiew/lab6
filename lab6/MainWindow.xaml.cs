using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<int> queue;
        private Stack<Book> Stack1;
        private LinkedList<int> lList;
        private Dictionary<string, string> dDir;

        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            queue = new Queue<int>();
            Stack1 = new Stack<Book>();
            lList = new LinkedList<int>();
            dDir = new Dictionary<string, string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (double.Parse(tbElement.Text) >= 0)
                {
                    listLab1.Add(int.Parse(tbElement.Text));
                    lbList.ItemsSource = null;
                    lbList.ItemsSource = listLab1;
                    tbElement.Text = "";
                }
                else
                {
                    MessageBox.Show("Вводите положительные числа");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:  {ex}, вводите корректные данные");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lbList.SelectedIndex;
                listLab1.RemoveAt(index);
                lbList.ItemsSource = null;
                lbList.ItemsSource = listLab1;
            }
            catch
            {
                MessageBox.Show("Выберите элемент для удаления");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = listLab1.Count();
                int b = listLab1[0];
                for (int a = 0; a < i; a++)
                {
                    if (listLab1[a] <= b)
                    {
                        Result.Text = "Массив не возрастающий";
                    }
                    else
                    {

                        Result.Text = "Масив Возрастает";
                    }
                }
            }
            catch { MessageBox.Show("Ваш массив пуст"); }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {

                Book a = new Book(nameBook.Text, double.Parse(cost.Text));
                Stack1.Push(a);
                lbstack.ItemsSource = null;
                lbstack.ItemsSource = Stack1;

                double sum = 0;
                double count = 0;
                foreach (Book item in Stack1)
                {
                    sum += item.Number;
                    count++;

                }
                double c = sum / count;

                Result1.Text = c.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Stack1.Count > 1)
                {
                    Stack1.Pop();
                    lbstack.ItemsSource = null;
                    lbstack.ItemsSource = Stack1;
                }
                else
                {
                    MessageBox.Show("Первый эллемент стека не удаляется");
                }
            }
            catch
            {
                MessageBox.Show("Не получилось удалить");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {

                if (int.Parse(tbLists52.Text) != 9)
                {
                    lList.AddFirst(int.Parse(tbLists52.Text));
                    listik.ItemsSource = null;
                    listik.ItemsSource = lList;
                    tbLists52.Text = "";

                }
                else
                {

                    lList.AddFirst(int.Parse(tbLists52.Text));
                    LinkedListNode<int> node = lList.First;
                    LinkedListNode<int> newNode = new LinkedListNode<int>(11);
                    lList.AddAfter(node, newNode);
                    listik.ItemsSource = null;
                    listik.ItemsSource = lList;
                    tbLists52.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошел сбой, попробуйте еще раз, ОШИБКА : {ex}");


            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(tbLists52.Text) != 9)
                {
                    lList.AddLast(int.Parse(tbLists52.Text));
                    listik.ItemsSource = null;
                    listik.ItemsSource = lList;
                    tbLists52.Text = "";

                }
                else
                {
                    lList.AddLast(int.Parse(tbLists52.Text));
                    lList.AddLast(11);

                    listik.ItemsSource = null;
                    listik.ItemsSource = lList;
                    tbLists52.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошел сбой, попробуйте еще раз, ОШИБКА : {ex}");


            }
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (lList.Count > 1)
            {
                lList.RemoveLast();
                listik.ItemsSource = null;
                listik.ItemsSource = lList;
            }
            else
            {
                MessageBox.Show("Первый элемент массива не удаляется");

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                dDir.Add("дубинин", "Лучший преподаватель бизнес колледжа");
                dDir.Add("говнокод", "плохой, нечитаемый код");
                dDir.Add("209", "лучший кабинет КБК");
                dDir.Add("бекенд", "програмная часть приложения,сайта,сервера");
                dDir.Add("галера", "работа с низкой зарплатой и плохим отношением к сотрудникам");
                dDir.Add("гит", "система контроля версий GIT или сервеса GitHub ");
                dDir.Add("жаба", "язык программирования Java");
                dDir.Add("жабаскрипт", "язык программирования JavaScript");
                dDir.Add("бета", "не готовая, тестовая версия приложения");
                dDir.Add("бэкап", "резервная копия или процесс создания резервной копии приложения");
                dDir.Add("костыль", "решение проблемы в коде не стандартными/неоптимальными методами");
                direct.ItemsSource = null;
                direct.ItemsSource = dDir;
                search.Text = dDir.Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }





        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {


            direct.ItemsSource = null;
            direct.ItemsSource = dDir;
            if (dDir.ContainsKey(directvv.Text.ToLower()))
            {
                res.Text = dDir[directvv.Text];



            }
            else
            {
                res.Text = "Нет такого определения";

            }

        }

    }
}