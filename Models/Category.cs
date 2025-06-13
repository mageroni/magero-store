using System.ComponentModel.DataAnnotations;

namespace magero_store.Models
{
    /// <summary>
    /// Representa una categoría de productos en la tienda.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Identificador único de la categoría.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la categoría.
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Descripción de la categoría.
        /// </summary>
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// Colección de productos que pertenecen a esta categoría.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}