
window.playAllVideos = () => {
    const videos = document.querySelectorAll('.auto-play-video');
    videos.forEach(video => {
        video.muted = true;
        video.play().catch(e => console.warn("Autoplay prevented:", e));
    });
};

window.scrollToBottom = () => {
    window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });
};