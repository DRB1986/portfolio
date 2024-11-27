import React from 'react';
import AboutMe from './components/AboutMe';
import Skills from './components/Skills';
import Experience from './components/Experience';
import Education from './components/Education';
import GitHubProjects from './components/GitHubProjects';
import './App.css';

function App() {
  return (
    <div className="App">
      <header>
        <h1>David Bex Portfolio</h1>
        <nav>
          <a href="#about">About Me</a>
          <a href="#skills">Skills</a>
          <a href="#experience">Experience</a>
          <a href="#education">Education</a>
          <a href="#github-projects">GitHub Projects</a>
        </nav>
      </header>
      <main>
        <AboutMe />
        <Skills />
        <Experience />
        <Education />
        <GitHubProjects />
      </main>
    </div>
  );
}

export default App;