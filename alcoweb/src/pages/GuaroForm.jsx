import { useState } from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import { GetCategories } from "../services/categoryService";
import { GetTypes } from "../services/TypeService";

export default function GuaroForm() {
  const categories = GetCategories();
  const [categorySelected, setCategorySelected] = useState(0);
  const [typeSelected, setTypeSelected] = useState(0);
  const types = GetTypes(categorySelected);
  const [formData, setFormData] = useState({
    name: "",
    value: 0,
    image: null,
    category: 0,
    type: 0
  });
  const [imagePreview, setImagePreview] = useState(null);

  console.log(formData);

  const handleChange = (e) => {
    const { name, value, type, files } = e.target;
    if(type === "file"){
      const file = files[0];
      if (file && file.type.match("image.*")){
        const reader = new FileReader();
        reader.onload = (event) => {
          setFormData((prevFormData) => ({
            ...prevFormData,
            image: event.target.result,
          }));
          setImagePreview(event.target.result);
        };
        reader.readAsDataURL(file);
      } else {
        alert("Please select valid image file (jpeg, jpg)");
      }
    } else {
      setFormData((prevFormData) => ({
        ...prevFormData,
        [name]: value,
      }));
    }
  };

  return (
    <div className="container mt-5">
      <div className="row justify-content-center">
        <div className="col-md-6">
          <form>
            <div className="mb-3">
              <label htmlFor="InputName" className="form-label">
                Nombre
              </label>
              <input
                type="text"
                className="form-control"
                name="name"
                value={formData.name}
                onChange={handleChange}
                placeholder="Pilsen"
              />
            </div>
            <label htmlFor="InputValue" className="form-label">
              Precio
            </label>
            <div className="input-group mb-3">
              <span className="input-group-text">₡</span>
              <input
                type="number"
                className="form-control"
                name="value"
                value={formData.value}
                onChange={handleChange}
              />
              <span className="input-group-text">.00</span>
            </div>
            <label htmlFor="InputValue" className="form-label">
              Imagen
            </label>
            <div className="input-group mb-3">
              <input
                type="file"
                className="form-control"
                name="image"
                accept="image/jpeg, image/jpg, image/png"
                onChange={handleChange}
              />
            </div>
            {imagePreview && (
              <div className="mb-3">
                <img src={imagePreview} alt="Preview" className="img-thumbnail" />
              </div>
            )}
            <div className="mt-3">
              {categorySelected != 0 && categorySelected != "Categoría" ? (
                <label htmlFor="InputPassword1" className="form-label">
                  Categoría
                </label>
              ) : null}
              <select
                className="form-select"
                name="category"
                value={formData.category}
                onChange={(e) => {
                  setCategorySelected(e.target.value);
                  handleChange(e)
                }}
              >
                <option>Categoría</option>
                {categories.map((category) => (
                  <option value={category.categoryId} key={category.categoryId}>
                    {category.name}
                  </option>
                ))}
              </select>
            </div>
            <div className="mt-4">
            {typeSelected != 0 && typeSelected != "Tipo" ? (
                <label htmlFor="InputPassword1" className="form-label">
                  Tipo
                </label>
              ) : null}
              <select
                className="form-select"
                name="type"
                value={formData.type}
                onChange={(e) => {
                  setTypeSelected(e.target.value);
                  handleChange(e);
                }}
              >
                <option>Tipo</option>
                {types.map((type) => (
                  <option value={type.typeId} key={type.typeId}>
                    {type.name}
                  </option>
                ))}
              </select>
            </div>

            <button type="submit" className="btn btn-secondary mt-3">
              Submit
            </button>
          </form>
        </div>
      </div>
    </div>
  );
}
