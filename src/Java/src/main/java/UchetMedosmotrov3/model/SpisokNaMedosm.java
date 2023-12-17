package UchetMedosmotrov3.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import UchetMedosmotrov3.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import java.util.Date;
import java.util.List;

/**
 * Entity implementation class for Entity: СписокНаМедосм
 */
@Entity(name = "IISUchetMedosmotrov3СписокНаМедосм")
@Table(schema = "public", name = "СписокНаМедосм")
public class SpisokNaMedosm {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "НомерДок")
    private Integer номердок;

    @Column(name = "Дата")
    private Date дата;

    @OneToMany(mappedBy = "spisoknamedosm", fetch = FetchType.LAZY, cascade = CascadeType.REMOVE)
    private List<KontingentSotr> kontingentsotrs;


    public SpisokNaMedosm() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Integer getНомерДок() {
      return номердок;
    }

    public void setНомерДок(Integer номердок) {
      this.номердок = номердок;
    }

    public Date getДата() {
      return дата;
    }

    public void setДата(Date дата) {
      this.дата = дата;
    }


}