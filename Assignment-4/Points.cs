/*******************************************************************************************************************
 *                                                                                                                 *
 *  CSCI 473/504							Assignment 4 								 Fall 2018                 *                                           
 *																										           *
 *  Programmer's: Sandeep Alla (z1821331) Gayathri Sanikommu (z1822939) Venkata SuryaVamsi Maddukuri (z1855404)    *  
 *																										           *
 *  Date Due  : November 1, 2018			File :	Points.cs     					     				           *                          
 *																										           *
 *  Purpose   : To write a program that allows user to perform paint operations like drawing ,erasing, painting    *
 *																							                       *
 ******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
	class Points
	{
		private int x1;
		private int x2;
		private int y1;
		private int y2;		
		private Color linePaintColor;
		private int size;
		private string type;

		//Constructor
		public Points(int x1, int x2, int y1, int y2, Color linePaintColor, int size, string type)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.y1 = y1;
			this.y2 = y2;
			this.linePaintColor = linePaintColor;
			this.size = size;
			this.type = type;
		}

		public int X1 // Name method
		{
			get { return x1; } //Get property
			set { x1 = value; } // Set property
		}

		public int X2 // Name method
		{
			get { return x2; } //Get property
			set { x2 = value; } // Set property
		}

		public int Y1 // Name method
		{
			get { return y1; } //Get property
			set { y1 = value; } // Set property
		}

		public int Y2 // Name method
		{
			get { return y2; } //Get property
			set { y2 = value; } // Set property
		}

		public Color LinePaintColor // Name method
		{
			get { return linePaintColor; } //Get property
			set { linePaintColor = value; } // Set property
		}

		public int Size // Name method
		{
			get { return size; } //Get property
			set { size = value; } // Set property
		}

		public string Type // Name method
		{
			get { return type; } //Get property
			set { type = value; } // Set property
		}


	}
}
