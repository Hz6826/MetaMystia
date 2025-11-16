using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x02000047 RID: 71
	public class DebugConsoleBase : MonoBehaviour
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x000B9CA8 File Offset: 0x000B7EA8
		// Note: this type is marked as 'beforefieldinit'.
		static DebugConsoleBase()
		{
			Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "DebugConsoleBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr);
			DebugConsoleBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr, 100664730);
			DebugConsoleBase.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr, 100664731);
			DebugConsoleBase.NativeMethodInfoPtr_OnStart_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr, 100664732);
			DebugConsoleBase.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr, 100664733);
			DebugConsoleBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr, 100664734);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000B9D3C File Offset: 0x000B7F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36336, XrefRangeEnd = 36342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugConsoleBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000B9D70 File Offset: 0x000B7F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36342, XrefRangeEnd = 36349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugConsoleBase.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000B9DA4 File Offset: 0x000B7FA4
		[CallerCount(0)]
		public unsafe virtual void OnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugConsoleBase.NativeMethodInfoPtr_OnStart_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000B9DE0 File Offset: 0x000B7FE0
		[CallerCount(0)]
		public unsafe virtual void OnDrawDebugConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugConsoleBase.NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000B9E1C File Offset: 0x000B801C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugConsoleBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugConsoleBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugConsoleBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00007188 File Offset: 0x00005388
		public DebugConsoleBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawDebugConsole_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
