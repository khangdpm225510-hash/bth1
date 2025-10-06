namespace Real_Mediator_XinNghiPhep
{
    public class NhanVien
    {
        protected IMediator mediator;
        public string Ten { get; set; }
        public string CapBac { get; set; }

        public NhanVien(IMediator mediator, string ten, string capBac)
        {
            this.mediator = mediator;
            Ten = ten;
            CapBac = capBac;
        }

        public void GuiYeuCau(string yeuCau)
        {
            mediator.GuiYeuCau(yeuCau, this);
        }
    }
}
