using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica
{

    class Program
    {
        static void Main(string[] args)
        {

            //almaceno los datos
            string[] array = new string[] { "a5","d5","c2","b5","b5","h8","g6","b2","e1","g6"
                ,"b3","g8","c5","g3","e8","f6","e1","b8","b4","d3","h4","c7","a5","h5","f7","c8",
                "b2","g4","f5","g3","e4","h1","d2","h6","e3","a5","f4","c7","h3","d6","b7","e3",
                "a3","g6","g6","a3" };

            //resultado por defecto es N
            char resultado = 'N';
            //hago un for que recorra los datos y que valla sumando de 2 para darle el manejo
            // a las parejas
            for(int i = 0; i < array.Length-1; i += 2)
            {
                resultado = 'N';
                //convierto cada dato en un array car ejm: b7 = ['b','7'] 
                //y asigno el valor para el rey y la reina
                var arrayCharRey = array[i].ToCharArray();
                var arrayCharReina = array[i + 1].ToCharArray();

                //asigno valores de la fila y colum que esta dado por el numero horizontal 
               // y vertical
                //respectivamente y comparar los valores, si son coincidentes quiere decir
                //que la reina pueda 
                //casar al rey
                var vRey = arrayCharRey[0];
                var vReina = arrayCharReina[0];
                var hReina = arrayCharReina[1];
                var hRey = arrayCharRey[1];

                //hago la comparacion entre el valor de la fila y la colum
                if(vReina == vRey || hReina == hRey)
                {
                    resultado = 'Y';
                }

                //si la anterior comparación no es true entonces el siguiente 
                //  condicional se cumple
                //este es el manejo para las diagonales
                if(resultado == 'N')
                {
                    //asigno variable con los valores del rey y la reina filas
                    //porque ya estan en el formato correcto
                    //y poder sumar mas adelante
                    int filaRey = arrayCharRey[1];
                    int filaReina = arrayCharReina[1];
                    int columRey = 0;
                    int columReina = 0;

                    //para el rey asigno el valor de la columna a = 0, b =1 , c = 2...
                    //para poder sumar mas adelante
                    switch (arrayCharRey[0])
                    {
                        case 'a':
                            columRey = 0;
                            break;
                        case 'b':
                            columRey = 1;
                            break;
                        case 'c':
                            columRey = 2;
                            break;
                        case 'd':
                            columRey = 3;
                            break;
                        case 'e':
                            columRey = 4;
                            break;
                        case 'f':
                            columRey = 5;
                            break;
                        case 'g':
                            columRey = 6 ;
                            break;
                        case 'h':
                            columRey = 7;
                            break;
                    }

                    //para el reina asigno el valor de la columna a = 0, b =1 , c = 2...
                    //para poder sumar mas adelante
                    switch (arrayCharReina[0])
                    {
                        case 'a':
                            columReina = 0;
                            break;
                        case 'b':
                            columReina = 1;
                            break;
                        case 'c':
                            columReina = 2;
                            break;
                        case 'd':
                            columReina = 3;
                            break;
                        case 'e':
                            columReina = 4;
                            break;
                        case 'f':
                            columReina = 5;
                            break;
                        case 'g':
                            columReina = 6;
                            break;
                        case 'h':
                            columReina = 7;
                            break;
                    }

                    /*/para saber si dos valores pertenecen a la misma diagonal 
                     * hago lo siguiente.
                       si la diagonal tiene sentido derecha a izquierda
                       sumo los valores de las coordenadas
                       para 2,0  y 0,2 -> (2+0) == (0+2) -> 'Y'
                                                           (0,0)(0.1)(0,2)
                                                           (1,0)(1,1)(1,2)
                                                           (2,0)(2,1)(2,2)
                        ejm diagonal D-I:
                                                               /
                                                              /
                                                             /
                                                            /
                                                           /


                    si la diagonal tiene sentido a izquierda a derecha resta valores
                    de las coordenas.
                    para 2,2 y 0,0 -> (2-2)==(0-0) -> 'Y'
                                                           (0,0)(0.1)(0,2)
                                                           (1,0)(1,1)(1,2)
                                                           (2,0)(2,1)(2,2)
                     
                    ejm diagonal I-D:
                      \
                       \
                        \
                         \ 
                          \
                           \      

                    /*/

                    if ((filaRey + columRey) == (filaReina + columReina) || 
                        (filaRey - columRey) == (filaReina - columReina) ){

                        resultado = 'Y';
                    }
                }
                if(i < array.Length - 2)
                {
                    Console.Write(resultado+ " ");
                }else if(i < array.Length)
                {
                    Console.Write(resultado);
                }

            }

            Console.ReadKey();
        }
    }
}
