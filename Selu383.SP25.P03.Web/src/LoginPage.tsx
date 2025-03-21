import { useState } from "react";
import { Link } from "react-router-dom";
import "./App.css"; // Importing the new CSS file

interface LoginPageProps {
  onClose: () => void;
}

function LoginPage({ onClose }: LoginPageProps) {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState(false);

  return (
    <div className="modal-overlay">
      <div className="modal animate-modal">
        {/* Close Button */}
        <button className="close-button" onClick={onClose}>
          ✖
        </button>

        {/* Modal Title */}
        <h2 className="modal-title">Sign In</h2>

        {/* Sign-In Form */}
        <form className="login-form">
          <div className="form-group">
            <label>Email</label>
            <input
              type="email"
              placeholder="Enter your email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
            />
          </div>

          <div className="form-group">
            <label>Password</label>
            <div className="password-container">
              <input
                type={showPassword ? "text" : "password"}
                placeholder="Enter your password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
              <button
                type="button"
                className="toggle-password"
                onClick={() => setShowPassword(!showPassword)}
              >
                👁️
              </button>
            </div>
          </div>

          <Link to="/forgot-password" className="forgot-password">
            Forgot Password?
          </Link>

          <button type="submit" className="modal-sign-in">
            Sign in
          </button>

          <p className="signup-text">
            Not a member?{" "}
            <Link to="/register" className="bold-link">
              Create an Account
            </Link>
          </p>
        </form>
      </div>
    </div>
  );
}

export default LoginPage;
