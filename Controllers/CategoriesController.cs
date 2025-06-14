using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using magero_store.Data;
using magero_store.Models;

namespace magero_store.Controllers
{
    /// <summary>
    /// Controlador para la gestión de categorías.
    /// </summary>
    public class CategoriesController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        /// <summary>
        /// Inicializa una nueva instancia del controlador de categorías.
        /// </summary>
        /// <param name="context">Contexto de base de datos.</param>
        public CategoriesController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Muestra la lista de categorías.
        /// </summary>
        /// <returns>Vista con la lista de categorías.</returns>
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        /// <summary>
        /// Muestra los detalles de una categoría específica.
        /// </summary>
        /// <param name="id">ID de la categoría.</param>
        /// <returns>Vista con los detalles de la categoría.</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        /// <summary>
        /// Muestra el formulario para crear una nueva categoría.
        /// </summary>
        /// <returns>Vista del formulario de creación.</returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Procesa la creación de una nueva categoría.
        /// </summary>
        /// <param name="category">Datos de la categoría a crear.</param>
        /// <returns>Redirección a la lista de categorías o vista con errores.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        /// <summary>
        /// Muestra el formulario para editar una categoría existente.
        /// </summary>
        /// <param name="id">ID de la categoría a editar.</param>
        /// <returns>Vista del formulario de edición.</returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        /// <summary>
        /// Procesa la edición de una categoría existente.
        /// </summary>
        /// <param name="id">ID de la categoría.</param>
        /// <param name="category">Datos actualizados de la categoría.</param>
        /// <returns>Redirección a la lista de categorías o vista con errores.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        /// <summary>
        /// Muestra la confirmación para eliminar una categoría.
        /// </summary>
        /// <param name="id">ID de la categoría a eliminar.</param>
        /// <returns>Vista de confirmación de eliminación.</returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        /// <summary>
        /// Procesa la eliminación de una categoría.
        /// </summary>
        /// <param name="id">ID de la categoría a eliminar.</param>
        /// <returns>Redirección a la lista de categorías.</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Verifica si una categoría existe.
        /// </summary>
        /// <param name="id">ID de la categoría.</param>
        /// <returns>True si la categoría existe, false en caso contrario.</returns>
        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}