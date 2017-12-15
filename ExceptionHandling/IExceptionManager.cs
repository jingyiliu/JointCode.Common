//
// Authors:
//   ������ (Johnny Liu) <jingeelio@163.com>
//
// Copyright (c) 2017 ������ (Johnny Liu)
//
// Licensed under the LGPLv3 license. Please see <http://www.gnu.org/licenses/lgpl-3.0.html> for license text.
//

using System;

#if ENCRYPT
namespace JointCode.Internals
#else
namespace JointCode.Common.ExceptionHandling
#endif
{
    /// ����Ӧ��֪�����쳣������ִ������������ʱ����ʱ�жϵ�ǰ����ִ������������ָ���Ĵ���
    /// ���쳣�������ƣ��׳��쳣����Ŀ����������Ӧ�ó�������Ƿ��ܹ����쳣�лָ�������ִ�У�
    /// ������ָܻ���Ҳ�������ŵ��˳�Ӧ�ó����������һЩ�쳣��¼���������Ǽ򵥴ֱ����ж�Ӧ�ó���
    /// ���ǿ��Լ򵥽��쳣��Ϊ���¼������ͣ�
    /// 1. ������ڲ�״̬����ƻ����쳣���� JointCode �Ĵ����У����˼̳��� <see cref="FatalException"/> �� <see cref="LogicalException"/> ֮���
    ///    �쳣�����ڴ��ࡣ���磬��������IO ������쳣�����������쳣��Ӧ�ó�����Դ��쳣�лָ�������ִ�С�
    /// 2. ���ܻ���ڲ�״̬����ƻ����쳣���� JointCode �Ĵ����У���Ӧ�ڼ̳��� <see cref="LogicalException"/> ���쳣�����磬��Ч���������ݴ����
    ///    �쳣�����������쳣��Ӧ�ó������ѡ����쳣�лָ�������ִ�У�Ҳ����ֱ���ж�Ӧ�ó���ִ�С�
    /// 3. �϶�����ڲ�״̬����ƻ����쳣���� JointCode �Ĵ����У���Ӧ�ڼ̳��� <see cref="FatalException"/> ���쳣�����磬��Դ�Ľߡ���ջ���������
    ///    Υ�桢���쳣�����������쳣��Ӧ�ó���Ӧ���쳣�лָ�����Ӧ�ж�Ӧ�ó������С�
    /// ���ǿ��Լ򵥽��쳣��Ϊ���¼������ͣ�
    /// 1.������ڲ�״̬����ƻ����쳣�����磬��������IO ������쳣�����������쳣��Ӧ�ó�����Դ��쳣�лָ�������ִ�С�
    /// 2.���ܻ���ڲ�״̬����ƻ����쳣�����磬��Ч���������ݴ�����쳣�����������쳣��Ӧ�ó������ѡ����쳣�лָ�������ִ�У�Ҳ����ֱ���ж�Ӧ�ó���ִ�С�
    /// 3.�϶�����ڲ�״̬����ƻ����쳣�����磬��Դ�Ľߡ���ջ���������Υ�桢���쳣�����������쳣��Ӧ�ó���Ӧ���쳣�лָ�����Ӧֱ���ж�Ӧ�ó������С�

    /// ��ͬ���͵��쳣Ӧ�ü̳��Բ�ͬ���쳣���࣬�Ա��ܹ�ͨ�� <see cref="IExceptionManager"/> �� <see cref="IExceptionHandler"/> �����ʵ��Ĵ�����


    /// <see cref="IExceptionManager"/> ��Ŀ������ͨ�����ã������Ǵ������û���ͨ�������ļ��������ã���ʵ�ֲ�ͬ�쳣���͵Ĵ������ԣ����ܹ����ݲ�ͬ��
    /// �쳣���ʹ�����ͬ�� <see cref="IExceptionHandler"/> �����쳣������

    /// �Ӵ������ƵĽǶ��������쳣�������Դ�����ά�Ƚ��н�����
    /// 1. �쳣���ֵ�λ�ã�Ҳ�������ĸ�����ĸ������г������쳣������Ϊ��ͬ�������Ҫ���ǲ�һ���ģ���Щ����������ؼ��Եģ��������е��ʽ��״��룩��
    ///    ��Щ����ֻ��һ���ҵ���߼�����ˣ����ǳ����쳣ʱ��Ҫ��Ĵ�������Ҳ���ܻ�������ͬ�����磬���ڹؼ����������Ҫ�ڵ�һʱ��֪ͨ���Ĵ��뿪���ߣ�
    ///    ��������Ҫ֪ͨ�����쵼���Լ�ʱ�����޲���������һ��ҵ���߼����쳣������������Ǽ�¼һ����־�Ϳ����ˡ�
    /// 2. �쳣�����ͣ�ͨ��һЩ�������ã����Ը����쳣����������Ӧ�ó����Ƿ�������лָ�������ִ�С�
    /// 3. �����쳣ʱ�Ļ�����Ϣ���������ϵͳ���ƺͰ汾��CPU ռ������ȣ����˲�����Ϣ�Ĳ�׽Ӧ������־ģ����ɡ�
    public interface IExceptionManager
    {
        IExceptionHandler GetExceptionHandler(Type type);
        IExceptionHandler GetExceptionHandler(string handlerName);
    }
}