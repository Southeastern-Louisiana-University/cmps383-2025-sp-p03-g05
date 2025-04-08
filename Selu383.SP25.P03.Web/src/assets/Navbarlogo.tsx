import './Navbar.css';
import logo from './assets/logo.png'; 
 

const Navbar = () => {
  return (
    <nav className="navbar">
      <div className="navbar-left">
        <img src={logo} alt="Logo" className="logo" />
        <span className="brand-name">MyApp</span>
      </div>
      <div className="navbar-right">
        <a href="#">Home</a>
        <a href="#">About</a>
        <a href="#">Contact</a>
      </div>
    </nav>
  );
};

export default Navbar;



