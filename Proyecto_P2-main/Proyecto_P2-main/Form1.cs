﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //esta clase esta afuera de los if por que todos tienen un nombre, fecha de nacimiento  y edad, estos son para todas las clases
            Persona perso = new Persona();
            perso.Nombre = textBox1.Text;
            perso.FechaNa = textBox2.Text;
            perso.Edad = textBox3.Text;
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
            if (radioButton1.Checked) //checa si el boton es seleccionado para utilizar la clase alumno
            {
                Alumnos alumn = new Alumnos();
                alumn.Matricula = textBox4.Text;//Guarda lo que esta en el textBox4 en la clase alumn.Matricula
                alumn.Carrera = textBox5.Text;//Guarda lo que esta en el textBox5 en la clase alumn.Carrera
            }
            if (radioButton2.Checked)//checa si el boton es seleccionado para utilizar la clase Empleado
            {
                Empleado emple = new Empleado(); //nueva clase empleado
                emple.Dni = textBox4.Text;  //Guarda lo que esta en el textBox4 en la clase emple.Dni
                emple.Puesto = textBox5.Text;//Guarda lo que esta en el textBox5 en la clase emple.Puesto
                emple.Sueldo = textBox6.Text;//Guarda lo que esta en el textBox6 en la clase emple.Sueldo
            }
            if (radioButton3.Checked)//checa si el boton es seleccionado para utilizar la clase Docente
            {
                Docente docent = new Docente();
                docent.Dni = textBox4.Text;
                docent.Puesto = textBox5.Text;
                docent.Sueldo = textBox6.Text;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de borrar las cajas de texto
            textBox1.Clear(); //borra lo de textbox1
            textBox2.Clear();//borra lo de textbox2
            textBox3.Clear();//borra lo de textbox3
            textBox4.Clear();//borra lo de textbox4
            textBox5.Clear();//borra lo de textbox5
            textBox6.Clear();//borra lo de textbox6
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de terminar la ejecucion de la interfaz
            Application.Exit(); //sale de aplicacion
        }

    }
}
