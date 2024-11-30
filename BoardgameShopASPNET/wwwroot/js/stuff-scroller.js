const catalogs = document.querySelectorAll('.product-card');

catalogs.forEach(catalog => {
    const images = catalog.querySelectorAll('.photo-stuff');
    const controlls = catalog.querySelectorAll('.controlls');
    let imageIndex = 0;

    function show(index) {
        images[imageIndex].classList.remove('active');
        images[index].classList.add('active');
        imageIndex = index;
    }

    controlls.forEach((e) => {
        e.addEventListener('click', (event) => {
            if (event.target.classList.contains('prev-btn')) {
                let index = imageIndex - 1;

                if (index < 0) {
                    index = images.length - 1;
                }

                show(index);
            } else if (event.target.classList.contains('next-btn')) {
                let index = imageIndex + 1;
                if (index >= images.length) {
                    index = 0;
                }
                show(index);
            }
        });
    });

    show(imageIndex);
});