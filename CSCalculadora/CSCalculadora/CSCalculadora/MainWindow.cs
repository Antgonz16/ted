using System;
using Gtk;
using static System.Net.Mime.MediaTypeNames;
using Application = Gtk.Application;

public partial class MainWindow : Gtk.Window
{
    int contador;
    float num1;
    float num2;
    int contador1;
    float result;
    int opcion;
    Calculadora operacion =new Calculadora();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        BSuma.ModifyBg(StateType.Normal, new Gdk.Color(120, 140, 33));
        BResta.ModifyBg(StateType.Normal, new Gdk.Color(130, 150, 33));
        BProducto.ModifyBg(StateType.Normal, new Gdk.Color(140, 160, 33));
        BCociente.ModifyBg(StateType.Normal, new Gdk.Color(150, 170, 33));
        BVaciar.ModifyBg(StateType.Normal, new Gdk.Color(160, 180, 33));

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
        num1 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
        opcion = 4;
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
        num1 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
        opcion = 3;
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
        num1 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
        opcion = 2;
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
        num2 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;

        switch(opcion)
        {
            case 1:
                result = operacion.suma(num1, num2);
                Pantalla.InsertText(Convert.ToString(result));
                contador1++;
                if(result>=1)
                {
                    break;
                }
                break;
            case 2:
                result = operacion.resta(num1, num2);
                Pantalla.InsertText(Convert.ToString(result));
                contador1++;
                if(result>=1)
                {
                    break;
                }
                break;
            case 3:
                result = operacion.producto(num1, num2);
                Pantalla.InsertText(Convert.ToString(result));
                contador1++;
                if (result>=1)
                {
                    break;
                }
                break;
            case 4:
                result = operacion.cociente(num1, num2);
                Pantalla.InsertText(Convert.ToString(result));
                contador1++;
                if (result>=1)
                {
                    break;
                }
                break;



        }
    }

    protected void OnBSumaClicked(object sender, EventArgs e)
    {
        num1 = Convert.ToSingle(Pantalla.Text);
        Pantalla.DeleteText(0, Pantalla.Text.Length);
        contador = 0;
        opcion = 1;

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
