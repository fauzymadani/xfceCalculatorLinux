using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        button.Clicked += OnButtonClicked;
        button1.Clicked += Click1;
        button2.Clicked += Click2;
        button3.Clicked += Click3;
        button4.Clicked += Click4;
        button5.Clicked += Click5;
        button6.Clicked += Click6;
        button7.Clicked += Click7;
        button8.Clicked += Click8;
        button9.Clicked += Click9;

        tambah.Clicked += tambahkan;
        kurang.Clicked += kurangi;
        perkalian.Clicked += kalikan;
        bagi.Clicked += bagikan;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void OnButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string label = button.Label;
        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click1(object sender, EventArgs e)
    {
        Button button1 = (Button)sender;
        string label = button1.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click2(object sender, EventArgs e)
    {
        Button button2 = (Button)sender;
        string label = button2.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click3(object sender, EventArgs e)
    {
        Button button3 = (Button)sender;
        string label = button3.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click4(object sender, EventArgs e)
    {
        Button button4 = (Button)sender;
        string label = button4.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click5(object sender, EventArgs e)
    {
        Button button5 = (Button)sender;
        string label = button5.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click6(object sender, EventArgs e)
    {
        Button button6 = (Button)sender;
        string label = button6.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click7(object sender, EventArgs e)
    {
        Button button7 = (Button)sender;
        string label = button7.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click8(object sender, EventArgs e)
    {
        Button button8 = (Button)sender;
        string label = button8.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void Click9(object sender, EventArgs e)
    {
        Button button9 = (Button)sender;
        string label = button9.Label;

        if (int.TryParse(label, out int number))
        {
            entry1.Text += number.ToString(); // Menambahkan nomor sebagai string ke Entry
        }
        else
        {
            // Penanganan jika label bukan angka
            Console.WriteLine("Label ini bukan angka!");
        }
    }

    protected void tambahkan(object sender, EventArgs e)
    {
        // Ambil teks dari Entry
        string entryText = entry1.Text;

        // Pisahkan teks berdasarkan tanda +
        string[] numbers = entryText.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);

        // Variabel untuk menyimpan hasil penjumlahan
        int sum = 0;

        // Konversi setiap angka dari string ke integer dan jumlahkan
        foreach (string number in numbers)
        {
            if (int.TryParse(number.Trim(), out int num)) // Trim untuk menghilangkan spasi yang tidak diinginkan
            {
                sum += num;
            }
        }

        // Tampilkan hasil penjumlahan di Entry atau komponen lain
        entry1.Text = sum.ToString();
    }

    // pengurangan
    protected void kurangi(object sender, EventArgs e)
    {
        // Ambil teks dari Entry
        string entryText = entry1.Text;

        // Pisahkan teks berdasarkan tanda -
        string[] numbers = entryText.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

        // Variabel untuk menyimpan hasil pengurangan
        int result = 0;

        if (numbers.Length > 0 && int.TryParse(numbers[0].Trim(), out int firstNumber))
        {
            // Inisialisasi dengan angka pertama
            result = firstNumber;

            // Mulai pengurangan dari angka kedua hingga akhir
            for (int i = 1; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i].Trim(), out int num))
                {
                    result -= num;
                }
            }
        }

        // Tampilkan hasil pengurangan di Entry atau komponen lain
        entry1.Text = result.ToString();
    }

    protected void kalikan(object sender, EventArgs e)
    {
        // Ambil teks dari Entry
        string entryText = entry1.Text;

        // Pisahkan teks berdasarkan tanda *
        string[] numbers = entryText.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);

        // Variabel untuk menyimpan hasil perkalian, dimulai dengan 1 karena 1 adalah elemen netral perkalian
        int result = 1;

        foreach (string number in numbers)
        {
            if (int.TryParse(number.Trim(), out int num))
            {
                result *= num;
            }
        }

        // Tampilkan hasil perkalian di Entry atau komponen lain
        entry1.Text = result.ToString();
    }
    protected void bagikan(object sender, EventArgs e)
    {
        // Ambil teks dari Entry
        string entryText = entry1.Text;

        // Pisahkan teks berdasarkan tanda /
        string[] numbers = entryText.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        // Variabel untuk menyimpan hasil pembagian
        double result = 0;

        if (numbers.Length > 0 && double.TryParse(numbers[0].Trim(), out double firstNumber))
        {
            // Inisialisasi dengan angka pertama
            result = firstNumber;

            // Mulai pembagian dari angka kedua hingga akhir
            for (int i = 1; i < numbers.Length; i++)
            {
                if (double.TryParse(numbers[i].Trim(), out double num))
                {
                    // Hindari pembagian dengan nol
                    if (num != 0)
                    {
                        result /= num;
                    }
                    else
                    {
                        entry1.Text = "Error: Division by zero";
                        return;
                    }
                }
            }
        }

        // Tampilkan hasil pembagian di Entry atau komponen lain
        entry1.Text = result.ToString();
    }



}
