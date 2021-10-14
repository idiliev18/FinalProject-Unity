mergeInto(LibraryManager.library, {
  SaveLocalStorage: function (value) {
    this.activeUser = JSON.parse(localStorage.getItem('activeUser'));
    if (activeUser) {

       this.activeUser.achievements.push(value);
      
      if(Set(this.activeUser.achievements).size === this.activeUser.achievements.length){
        localStorage.setItem('activeUser', JSON.stringify(this.activeUser));
      } else {
        console.log("Achievement already unlocked");
      }
    
    } else {
      console.log('No active user');
    }
  },

  LoadLocalStorage: function (key) {
    localStorage.getItem(Pointer_stringify(key));
  },
});