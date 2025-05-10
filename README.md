## APIs utilizadas

Se utilizaron dos APIs diferentes en este proyecto:

- **PokéAPI**: `https://pokeapi.co/api/v2/pokemon/{nombre}`  
  Proporciona información sobre un Pokémon específico, como su nombre, altura, peso e imagen.

- **The Cat API**: `https://api.thecatapi.com/v1/images/search`  
  Devuelve una imagen aleatoria de un gato.

---

## Dificultades encontradas y cómo se resolvieron

- **Problemas al deserializar el JSON de la PokéAPI**: La propiedad `front_default` no coincidía con el nombre definido en la clase C#.  
  ✅ Se resolvió utilizando la biblioteca `Newtonsoft.Json`, que permite deserializar ignorando las diferencias entre mayúsculas y minúsculas, evitando errores de mapeo.

- **Conflictos al mostrar dos imágenes en un solo PictureBox**: Inicialmente, se intentaban mostrar la imagen del Pokémon y del gato en el mismo control.  
  ✅ Se agregó un segundo `PictureBox` para manejar ambas imágenes por separado.

- **Las imágenes no se ajustaban correctamente al tamaño del PictureBox**: Las imágenes se veían distorsionadas o muy grandes.  
  ✅ Se ajustó la propiedad `SizeMode` a `StretchImage` o `Zoom` para que se adapten correctamente al espacio asignado.

---

## Aprendizajes

- Uso de APIs REST desde una aplicación de escritorio en C#.
- Diferencias y ventajas entre `System.Text.Json` y `Newtonsoft.Json`.
- Manejo de tareas asíncronas con `async`/`await`.
- Carga dinámica de imágenes en controles gráficos (`PictureBox`).
- Mejores prácticas en el manejo de errores y validación de datos externos.

---

## Apoyo de la inteligencia artificial

Se utilizó AI (ChatGPT) para:

- Diagnosticar errores relacionados con la deserialización de datos.
- Mejorar la estructura del código.
- Resolver dudas específicas sobre el comportamiento de los controles en Windows Forms.
- Obtener ejemplos y buenas prácticas para consumir y presentar datos de APIs públicas.

