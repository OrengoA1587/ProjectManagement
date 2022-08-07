
 
 
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Image;
 
import com.itextpdf.text.pdf.BarcodeEAN;
import com.itextpdf.text.pdf.BarcodeQRCode;
import com.itextpdf.text.pdf.PdfContentByte;
import com.itextpdf.text.pdf.PdfWriter;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;


 
 
 
public class barcode {
    
    
         public static void main(String[] args) throws   IOException, DocumentException
     {
          Document document = new Document();
                        PdfWriter pdfWriter = PdfWriter.getInstance(document, new FileOutputStream("HelloWorld.pdf"));
                         
                        document.open();
                        PdfContentByte pdfContentByte = pdfWriter.getDirectContent();
                       
                        
                        BarcodeEAN barcodeEAN = new BarcodeEAN();
                        barcodeEAN.setCodeType(BarcodeEAN.EAN13);
                        barcodeEAN.setCode("1234523453323");
                        Image codeEANImage = barcodeEAN.createImageWithBarcode(pdfContentByte, null, null);
                        codeEANImage.setAbsolutePosition(20, 600);
                        codeEANImage.scalePercent(100);
                        document.add(codeEANImage);
 
                        BarcodeQRCode barcodeQrcode = new BarcodeQRCode("examples.javacodegeeks.com/author/chandan-singh", 1, 1, null);
                        Image qrcodeImage = barcodeQrcode.getImage();
                        qrcodeImage.setAbsolutePosition(20, 500);
                        qrcodeImage.scalePercent(100);
                        document.add(qrcodeImage);
 
                        document.close();
         System.out.println("Created");
     }  
}
