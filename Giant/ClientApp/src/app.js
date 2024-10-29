// === CLIENT SETUP (React) ===

import React, { useState, useEffect } from 'react';
import './App.css';

function App() {
  const [courses, setCourses] = useState([]);

  useEffect(() => {
    fetch('http://localhost:5000/api/course')
      .then((res) => res.json())
      .then((data) => setCourses(data))
      .catch((error) => console.error('Error fetching courses:', error));
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        <h1>Learn Anything!</h1>
        <input type="text" placeholder="What do you want to learn today?" className="search-bar" />
      </header>
      <section className="courses">
        {courses.map((course) => (
          <div key={course.id} className="course-card">
            <img src={course.image} alt={course.title} />
            <h3>{course.title}</h3>
            <p>{course.description}</p>
          </div>
        ))}
      </section>
    </div>
  );
}

export default App;