//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Text;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /// <summary>
        /// Se añade la responsabilidad de anidar los string StepString, formando asi la receta.
        /// Se encarga únicamente de crear el string y no de imprimirlo porque sino, la clase podría tener mas de una
        /// razón de cambio.
        /// Además, decidimos crear el string en esta clase porque es la única que conoce todos los pasos.
        /// </summary>
        /// <returns>String para luego ser utilizado por ConsolePrinter.</returns>
        public string GetStringRecipe()
        {
            StringBuilder Receta = new StringBuilder();
            Receta.Append($"Receta de {this.FinalProduct.Description} \n");
            foreach (Step step in this.steps)
            {
                Receta.Append(step.StepString);
            }
            return Receta.ToString();
        }
    }
}