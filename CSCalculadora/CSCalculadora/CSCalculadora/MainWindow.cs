using System;
using Gtk;
using static System.Net.Mime.MediaTypeNames;
using Application = Gtk.Application;

public partial class MainWindow : Gtk.Window
{
    int contador;
    float num1;
    float num2;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBSieteClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "7");
    }

    protected void OnBOchoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "8");
    }

    protected void OnBNueveClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "9");

    }

    protected void OnBCocienteClicked(object sender, EventArgs e)
    {
    }

    protected void OnBCuatroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "4");

    }

    protected void OnBCincoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "5");

    }

    protected void OnBSeisClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "6");

    }

    protected void OnBProductoClicked(object sender, EventArgs e)
    {
    }

    protected void OnBUnoClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "1");

    }

    protected void OnBDosClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "2");

    }

    protected void OnBTresClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "3");
    }

    protected void OnBRestaClicked(object sender, EventArgs e)
    {
    }

    protected void OnButton14Clicked(object sender, EventArgs e)
    {
        if (contador == 0)
        {
            String display = Pantalla.Text.ToString();
            Pantalla.DeleteText(0, Pantalla.Text.Length);
            Pantalla.InsertText(display + ",");
            contador++;
        }
    }

    protected void OnBCeroClicked(object sender, EventArgs e)
    {
        String display = Pantalla.Text.ToString();
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        Pantalla.InsertText(display+ "0");
    }

    protected void OnBIgualClicked(object sender, EventArgs e)
    {
    }

    protected void OnBSumaClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
    }

    protected void OnBVaciarClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
    }

    protected void OnBCClicked(object sender, EventArgs e)
    {
        Pantalla.DeleteText(Pantalla.Text.Length - 1, Pantalla.Text.Length);

        String display = Pantalla.Text.ToString();
        if (!display.Contains(","))
        {
            contador = 0;
        }
    }
}
