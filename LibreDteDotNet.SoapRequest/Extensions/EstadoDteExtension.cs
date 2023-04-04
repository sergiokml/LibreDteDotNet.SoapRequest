namespace LibreDteDotNet.SoapRequest.Extensions
{
    public static class EstadoDteExtension
    {
        // IEstadoDte
        public static async Task<RESPUESTA> AsObject(this Task<IEstadoDte> estadoDteService)
        {
            IEstadoDte instance = await estadoDteService;
            return await instance.AsObject();
        }

        public static async Task<XDocument> AsXDocument(this Task<IEstadoDte> estadoDteService)
        {
            IEstadoDte instance = await estadoDteService;
            return await instance.AsXDocument();
        }

        // IEstadoDteUp
        public static async Task<RESPUESTA> AsObject(this Task<IEstadoDteUp> estadoDteService)
        {
            IEstadoDteUp instance = await estadoDteService;
            return await instance.AsObject();
        }

        public static async Task<XDocument> AsXDocument(this Task<IEstadoDteUp> estadoDteService)
        {
            IEstadoDteUp instance = await estadoDteService;
            return await instance.AsXDocument();
        }

        // IEstadoDteAv
        public static async Task<RESPUESTA> AsObject(this Task<IEstadoDteAv> estadoDteService)
        {
            IEstadoDteAv instance = await estadoDteService;
            return await instance.AsObject();
        }

        public static async Task<XDocument> AsXDocument(this Task<IEstadoDteAv> estadoDteService)
        {
            IEstadoDteAv instance = await estadoDteService;
            return await instance.AsXDocument();
        }
    }
}
