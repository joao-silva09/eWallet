using System.IdentityModel.Tokens.Jwt;

namespace eWallet.API.Configurations.Token
{
    public class TokenJWT
    {
        private JwtSecurityToken _token;

        internal TokenJWT(JwtSecurityToken token)
        {
            _token = token;
        }

        public DateTime ValidTo => _token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(_token);
    }
}
