using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea_2.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Tabla()
        {
            string[,] objt = new string[10,18];
            
            //Fila 1
            objt[0, 0] = "H";
            objt[0, 17] = "He";

            //Fila 2
            objt[1, 0] = "Li";
            objt[1, 1] = "Be";
            objt[1, 12] = "B";
            objt[1, 13] = "C";
            objt[1, 14] = "N";
            objt[1, 15] = "O";
            objt[1, 16] = "F";
            objt[1, 17] = "Ne";

            //Fila 3
            objt[2, 0] = "Na";
            objt[2, 1] = "Mg";
            objt[2, 12] = "Al";
            objt[2, 13] = "Si";
            objt[2, 14] = "P";
            objt[2, 15] = "S";
            objt[2, 16] = "Cl";
            objt[2, 17] = "Ar";
            
            //Fila 4
            objt[3, 0] = "K";
            objt[3, 1] = "Ca";
            objt[3, 2] = "Sc";
            objt[3, 3] = "Ti";
            objt[3, 4] = "V";
            objt[3, 5] = "Cr";
            objt[3, 6] = "Mn";
            objt[3, 7] = "Fe";
            objt[3, 8] = "Co";
            objt[3, 9] = "Ni";
            objt[3, 10] = "Cu";
            objt[3, 11] = "Zn";
            objt[3, 12] = "Ga";
            objt[3, 13] = "Ge";
            objt[3, 14] = "As";
            objt[3, 15] = "Se";
            objt[3, 16] = "Br";
            objt[3, 17] = "Kr";
            
            //Fila 5
            objt[4, 0] = "Rb";
            objt[4, 1] = "Sr";
            objt[4, 2] = "Y";
            objt[4, 3] = "Zr";
            objt[4, 4] = "Nb";
            objt[4, 5] = "Mo";
            objt[4, 6] = "Tc";
            objt[4, 7] = "Ru";
            objt[4, 8] = "Rh";
            objt[4, 9] = "Pd";
            objt[4, 10] = "Ag";
            objt[4, 11] = "Cd";
            objt[4, 12] = "In";
            objt[4, 13] = "Sn";
            objt[4, 14] = "Sb";
            objt[4, 15] = "Te";
            objt[4, 16] = "I";
            objt[4, 17] = "Xe";

            //Fila 6
            objt[5, 0] = "Cs";
            objt[5, 1] = "Ba";
            objt[5, 2] = "La-Lu";
            objt[5, 3] = "Hf";
            objt[5, 4] = "Ta";
            objt[5, 5] = "W";
            objt[5, 6] = "Re";
            objt[5, 7] = "Os";
            objt[5, 8] = "Ir";
            objt[5, 9] = "Pt";
            objt[5, 10] = "Au";
            objt[5, 11] = "Hg";
            objt[5, 12] = "Ti";
            objt[5, 13] = "Pb";
            objt[5, 14] = "Bi";
            objt[5, 15] = "Po";
            objt[5, 16] = "At";
            objt[5, 17] = "Rn";

            //Fila 7
            objt[6, 0] = "Fr";
            objt[6, 1] = "Ra";
            objt[6, 2] = "Ac-Lr";
            objt[6, 3] = "Rf";
            objt[6, 4] = "Db";
            objt[6, 5] = "Sg";
            objt[6, 6] = "Bh";
            objt[6, 7] = "Hs";
            objt[6, 8] = "Mt";
            objt[6, 9] = "Ds";
            objt[6, 10] = "Rg";
            objt[6, 11] = "Cn";
            objt[6, 12] = "Nh";
            objt[6, 13] = "Fi";
            objt[6, 14] = "Mc";
            objt[6, 15] = "Lv";
            objt[6, 16] = "Ts";
            objt[6, 17] = "Og";

            //Fila 8
            //Solo como espacio
            
            //Fila 9
            objt[8, 3] = "La";
            objt[8, 4] = "Ce";
            objt[8, 5] = "Pr";
            objt[8, 6] = "Nd";
            objt[8, 7] = "Pm";
            objt[8, 8] = "Sm";
            objt[8, 9] = "Eu";
            objt[8, 10] = "Gd";
            objt[8, 11] = "Tb";
            objt[8, 12] = "Dy";
            objt[8, 13] = "Ho";
            objt[8, 14] = "Er";
            objt[8, 15] = "Tm";
            objt[8, 16] = "Yb";
            objt[8, 17] = "Lu";

            //Fila 10
            objt[9, 3] = "Ac";
            objt[9, 4] = "Th";
            objt[9, 5] = "Pa";
            objt[9, 6] = "U";
            objt[9, 7] = "Np";
            objt[9, 8] = "Pu";
            objt[9, 9] = "Am";
            objt[9, 10] = "Cm";
            objt[9, 11] = "Bk";
            objt[9, 12] = "Cf";
            objt[9, 13] = "Es";
            objt[9, 14] = "Fm";
            objt[9, 15] = "Md";
            objt[9, 16] = "No";
            objt[9, 17] = "Lr";
            //Termina la lista

            //Mostrar elementos en la tabla
            //------------------------------
            int cont = 0;//contador
            for (int j = 0; j < 10; j++)
            {
                for(int i =0; i<18; i++)
                {
                    string s = Convert.ToString(cont);
                    ViewData[s] = objt[j,i];//Pasar informacion a la vista
                    cont += 1;//contador +1
                }
            }
            //------------------------------

            return View();
        }

    }
}