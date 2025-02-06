document.getElementById('categoryFilter').addEventListener('change', function() {
    const category = this.value;
    fetch(`/Products/FilterByCategory?category=${encodeURIComponent(category)}`)
        .then(response => response.json())
        .then(products => {
            const productList = document.getElementById('productList');
            productList.innerHTML = products.map(product => `
                <div class="col-md-4 mb-4">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title">${product.name}</h5>
                            <p class="card-text">${product.description}</p>
                            <p class="card-text">Precio: $${product.price}</p>
                            <a href="/Products/Details/${product.id}" class="btn btn-primary">Ver Detalles</a>
                        </div>
                    </div>
                </div>
            `).join('');
        });
});
