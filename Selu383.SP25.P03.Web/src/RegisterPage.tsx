import { useState } from "react";
import { Link } from "react-router-dom";

function RegisterPage() {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [username, setUsername] = useState("");
  const [email, setEmail] = useState("");
  const [confirmEmail, setConfirmEmail] = useState("");
  const [password, setPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [message, setMessage] = useState("");

  const handleRegister = async (e: React.FormEvent) => {
    e.preventDefault();
    setMessage("");

    if (email !== confirmEmail) {
      setMessage("\u26a0\ufe0f Emails do not match.");
      return;
    }

    if (password !== confirmPassword) {
      setMessage("\u26a0\ufe0f Passwords do not match.");
      return;
    }

    const response = await fetch("http://localhost:5000/api/authentication/register", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ firstName, lastName, userName: username, email, password }),
    });

    if (response.ok) {
      setMessage("\u2705 Account created successfully! You can now login.");
    } else {
      setMessage("\u26a0\ufe0f Error creating account. Try again.");
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal">
        <h2 className="modal-title">Create an Account</h2>

        {message && <p className="register-message">{message}</p>}

        <form onSubmit={handleRegister} className="login-form">
          <div className="register-row">
            <input type="text" placeholder="First Name" value={firstName} onChange={(e) => setFirstName(e.target.value)} required />
            <input type="text" placeholder="Last Name" value={lastName} onChange={(e) => setLastName(e.target.value)} required />
          </div>

          <input type="text" placeholder="Username" value={username} onChange={(e) => setUsername(e.target.value)} required />

          <div className="register-row">
            <input type="email" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)} required />
            <input type="email" placeholder="Confirm Email" value={confirmEmail} onChange={(e) => setConfirmEmail(e.target.value)} required />
          </div>

          <div className="register-row">
            <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} required />
            <input type="password" placeholder="Confirm Password" value={confirmPassword} onChange={(e) => setConfirmPassword(e.target.value)} required />
          </div>

          <button type="submit" className="modal-sign-in">Sign Up</button>
        </form>

        <p className="signup-text">
          Already have an account? <Link to="/" className="bold-link">Login here</Link>
        </p>
      </div>
    </div>
  );
}

export default RegisterPage;
