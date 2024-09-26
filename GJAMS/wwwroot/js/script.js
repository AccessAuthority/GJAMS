// Mobile Nav bar 
document.addEventListener('DOMContentLoaded', () => {
    const navToggle = document.querySelector('.nav-toggle');
    const navMenu = document.querySelector('.nav-menu');
    const navClose = document.querySelector('.nav-close');
    const navLinks = document.querySelectorAll('.nav-list a');

    navToggle.addEventListener('click', () => {
        navMenu.classList.add('active');
    });

    navClose.addEventListener('click', () => {
        navMenu.classList.remove('active');
    });
    
    navLinks.forEach(link => {
        link.addEventListener('click', () => {
            navMenu.classList.remove('active');
        });
    });
});


// AOS Initialization


