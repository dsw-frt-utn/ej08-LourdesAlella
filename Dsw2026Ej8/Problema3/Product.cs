using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    internal class Product
    {
        private string description_;

        public Product(string description)
        {
            description_ = description;
        }

        public void SetDescription(string nuevaDescription)
        {
            description_ = nuevaDescription;
        }

        public string GetDescription()
        {
            return description_;
        }
    }
}
