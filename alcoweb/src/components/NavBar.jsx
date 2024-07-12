import 'bootstrap/dist/css/bootstrap.min.css';

export default function NavBar() {

  return (
    <nav className="navbar navbar-expand-lg bg-body-tertiary">
  <div className="container-fluid">
    <a className="navbar-brand" href="#">
    <img src="src\assets\cocktail-svgrepo-com.svg" alt="Bootstrap" width="45" height="35" />
    AlcoApp
    </a>
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>
    <div className="collapse navbar-collapse " id="navbarSupportedContent">
      <ul className="navbar-nav me-auto mb-2 mb-lg-0 flex-grow-1">
        <li className="nav-item mx-5 w-25">
          <a className="nav-link fs-5 fw-bold" aria-current="page"  href="#">Agregar Guaro</a>
        </li>
        <li className="nav-item  w-25">
          <a className="nav-link fs-5 fw-bold" href="#">Guaros</a>
        </li>
        <li className="nav-item w-25">
          <a className="nav-link fs-5 fw-bold" href="#">Ventas</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
  )
}
