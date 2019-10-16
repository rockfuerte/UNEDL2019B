
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package examen;

/**
 *
 * @author kiuub
 */
public final class Habitacion extends Tapiz {

    private double costo;

    public Habitacion(double costo, double alto, double ancho) {
        super(alto, ancho);
        this.costo = costo;
    }

    public Habitacion(double alto, double ancho) {
        super(alto, ancho);
    }

    public Habitacion() {
    }

    /**
     *
     */
    public double getCosto() {
        return costo;
    }

    public void setCosto(double costo) {
        this.costo = costo;
    }

    @Override
    public int hashCode() {
        int hash = 5;
        hash = 67 * hash + (int) (Double.doubleToLongBits(this.costo) ^ (Double.doubleToLongBits(this.costo) >>> 32));
        return hash;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Habitacion other = (Habitacion) obj;
        if (Double.doubleToLongBits(this.costo) != Double.doubleToLongBits(other.costo)) {
            return false;
        }
        return true;
    }

    void setArea(double alto, double ancho) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public double calcularCosto(double area, double costo) {
        double costoFinal;
        costoFinal = area * costo;
        return costoFinal;
    }

}
