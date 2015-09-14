using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSample.Model
{
    class GitModel
    {
        private string login;
        private long id;
        private string avatar_url;

        public string getLogin() {
            return login;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }

        public long getId() {
            return id;
        }

        public void setId(long id) {
            this.id = id;
        }

        public string getAvatar_url() {
            return avatar_url;
        }

        public void setAvatar_url(string avatar_url) {
            this.avatar_url = avatar_url;
        }
    }
}
