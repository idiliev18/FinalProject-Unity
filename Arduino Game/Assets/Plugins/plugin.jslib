var LocalStoragePlugin = {
  $MyData: {
       activeUser: null,
   },

  SaveLocalStorage: function (value) {
    MyData.activeUser = JSON.parse(localStorage.getItem('activeUser'));

    if (MyData.activeUser) {
      MyData.activeUser.achievements.push(value);
      
      if(new Set(MyData.activeUser.achievements).size === MyData.activeUser.achievements.length) {
        localStorage.setItem('activeUser', JSON.stringify(MyData.activeUser));
      } else {
        console.log("Achievement already unlocked");
      }
    
    } else {
      console.log('No active user');
    }
  },

  LoadLocalStorage: function (value1) {
    MyData.activeUser = JSON.parse(localStorage.getItem('activeUser'));
    
    if (MyData.activeUser) {
      var str = MyData.activeUser.achievements.join(' ');
      return str;
    } else {
      console.log('No active user, when getting achievements');
      return "";
    }
  },
};

autoAddDeps(LocalStoragePlugin, '$MyData');
mergeInto(LibraryManager.library, LocalStoragePlugin);