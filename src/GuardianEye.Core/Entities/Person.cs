namespace GuardianEye.Core.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Caminho da foto de "referência" (ex: o rosto do seu pai) 
        // que a IA usará para comparar com as fotos da câmera.
        public string ReferenceImagePath { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
    }
}
