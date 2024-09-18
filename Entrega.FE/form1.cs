﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega.FE
{
    public partial class form1 : Form
    {
        
        //array de contacto para guardar y ver los susodichos

        private List<Contacto> listaContactos = new List<Contacto>();

        

        public form1()
        {
            InitializeComponent();
            
        }

        

        //actualizamos la lista de contactos con un metodo (no me sale dejarlo en mi clase y llamarlo posteriormente para hacer su tarea correspondiente)
        private void ActualizarListaContactos()
        {
            // Limpiar el contenido del ListBox
            //DataSource es una función de texto que devuelve el nombre de aplicación, de base de datos o de tabla de alias de una cuadrícula.
            lstContactos.DataSource = null;

            // Asignar la lista de contactos actualizada al ListBox
            lstContactos.DataSource = listaContactos;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // La expresión !string.IsNullOrEmpty(txtNombre.Text) en C# se utiliza para verificar si una cadena de texto no está vacía ni es nula. Vamos a desglosarla:
            //string.IsNullOrEmpty(txtNombre.Text): Esta parte verifica si la cadena de texto asociada con el control txtNombre es nula o vacía.
            //Retorna true si la cadena es nula o vacía.
            //Retorna false si la cadena contiene algún valor.
            //El símbolo de exclamación antes de la expresión es un operador de negación lógica, por lo que invierte el resultado.
            //Entonces, !string.IsNullOrEmpty(txtNombre.Text) significa que se verificará si el texto en txtNombre no es nulo y no está vacío. Si el resultado es true, significa que hay un valor válido en el campo de texto.


            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNumero.Text))
            {

                // creo el contacto nuevo con lo que ingreso
                Contacto nuevocontacto = new Contacto()
                {
                    nombre = txtNombre.Text,
                    telefono = txtNumero.Text,

                    
                };

                
                //agregamos el contacto a la lista 
                listaContactos.Add(nuevocontacto);

                // actualizar la lista de contactos en el list box
                ActualizarListaContactos();


                //limpio los campos de datos
                txtNombre.Text = "";
                txtNumero.Text = "";

            }
            else
            {
                MessageBox.Show("Por favor ingresa algo ");
            }


            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstContactos.SelectedIndex >= 0)
            {
                listaContactos.RemoveAt(lstContactos.SelectedIndex);
                ActualizarListaContactos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para eliminar.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de contactos: " +listaContactos.Count);
            lstContactos.Visible = true;
            txtNombre.Text.ToUpper();
            
        }

       
    }
}
