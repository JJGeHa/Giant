// === CLIENT COMPONENTS ===

import React from 'react';
import './Navbar.css';

function Navbar() {
  return (
    <nav className="navbar">
      <h2>Learning Platform</h2>
      <div className="nav-links">
        <a href="/">Home</a>
        <a href="/my-learning-path">My Learning Path</a>
        <a href="/categories">Categories</a>
      </div>
    </nav>
  );
}

export default Navbar;