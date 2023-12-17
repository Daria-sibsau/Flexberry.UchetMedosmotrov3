package UchetMedosmotrov3.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import UchetMedosmotrov3.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: Должности
 */
@Entity(name = "IISUchetMedosmotrov3Должности")
@Table(schema = "public", name = "Должности")
public class Dolzhnosti {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "Наименование")
    private String наименование;

    @Column(name = "IDДолжности")
    private Integer idдолжности;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Podrazdeleniya")
    @Convert("Podrazdeleniya")
    @Column(name = "Подразделения", length = 16, unique = true, nullable = false)
    private UUID _podrazdeleniyaid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Podrazdeleniya", insertable = false, updatable = false)
    private Podrazdeleniya podrazdeleniya;


    public Dolzhnosti() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getНаименование() {
      return наименование;
    }

    public void setНаименование(String наименование) {
      this.наименование = наименование;
    }

    public Integer getIDДолжности() {
      return idдолжности;
    }

    public void setIDДолжности(Integer idдолжности) {
      this.idдолжности = idдолжности;
    }


}