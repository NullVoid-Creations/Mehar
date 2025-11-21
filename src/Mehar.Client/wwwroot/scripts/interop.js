function IsDarkMode() {
    return window.matchMedia('(prefers-color-scheme: dark)').matches;
}

function GetItem(key) {
    return localStorage.getItem(key);
}

function SetItem(key, value) {
    localStorage.setItem(key, value);
}

function RemoveItem(key) {
    localStorage.removeItem(key);
}

function ClearItems() {
    localStorage.clear();
}