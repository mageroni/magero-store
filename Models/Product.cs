namespace magero_store.Models
{
    /// <summary>
    /// Clase que representa un producto en la tienda.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Precio del producto.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// URL de la imagen del producto.
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Categoría del producto.
        /// </summary>
        public string Category { get; set; }
    }
}