using System;
using Common.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using NightScene.EventUtility;
using TMPro;
using UnityEngine;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C2 RID: 450
	public class IncomeControllerBase : MonoBehaviour
	{
		// Token: 0x06003806 RID: 14342 RVA: 0x0015E874 File Offset: 0x0015CA74
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerBase()
		{
			Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr);
			IncomeControllerBase.NativeMethodInfoPtr_get_passionController_Protected_get_PassionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673883);
			IncomeControllerBase.NativeMethodInfoPtr_get_comboController_Protected_get_ComboController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673884);
			IncomeControllerBase.NativeMethodInfoPtr_get_clockController_Protected_get_ClockController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673885);
			IncomeControllerBase.NativeMethodInfoPtr_get_eventManager_Protected_get_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673886);
			IncomeControllerBase.NativeMethodInfoPtr_get_IzakayaDescription_Protected_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673887);
			IncomeControllerBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673888);
			IncomeControllerBase.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673889);
			IncomeControllerBase.NativeMethodInfoPtr_SetExp_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673890);
			IncomeControllerBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673891);
			IncomeControllerBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr, 100673892);
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x0015E96C File Offset: 0x0015CB6C
		public unsafe PassionController passionController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130065, RefRangeEnd = 130068, XrefRangeStart = 130062, XrefRangeEnd = 130065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_get_passionController_Protected_get_PassionController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PassionController>(intPtr3) : null;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0015E9AC File Offset: 0x0015CBAC
		public unsafe ComboController comboController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130071, RefRangeEnd = 130074, XrefRangeStart = 130068, XrefRangeEnd = 130071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_get_comboController_Protected_get_ComboController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComboController>(intPtr3) : null;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x0015E9EC File Offset: 0x0015CBEC
		public unsafe ClockController clockController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130077, RefRangeEnd = 130080, XrefRangeStart = 130074, XrefRangeEnd = 130077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_get_clockController_Protected_get_ClockController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClockController>(intPtr3) : null;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0015EA2C File Offset: 0x0015CC2C
		public unsafe EventManager eventManager
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 130083, RefRangeEnd = 130086, XrefRangeStart = 130080, XrefRangeEnd = 130083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_get_eventManager_Protected_get_EventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr3) : null;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x0015EA6C File Offset: 0x0015CC6C
		public unsafe TextMeshProUGUI IzakayaDescription
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 130089, RefRangeEnd = 130094, XrefRangeStart = 130086, XrefRangeEnd = 130089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_get_IzakayaDescription_Protected_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x0015EAAC File Offset: 0x0015CCAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67544, RefRangeEnd = 67546, XrefRangeStart = 67544, XrefRangeEnd = 67546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x0015EAE0 File Offset: 0x0015CCE0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerBase.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x0015EB1C File Offset: 0x0015CD1C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExp(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr_SetExp_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x0015EB5C File Offset: 0x0015CD5C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x0015EB98 File Offset: 0x0015CD98
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x0001F3E7 File Offset: 0x0001D5E7
		public IncomeControllerBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr_get_passionController_Protected_get_PassionController_0;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeMethodInfoPtr_get_comboController_Protected_get_ComboController_0;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeMethodInfoPtr_get_clockController_Protected_get_ClockController_0;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr_get_eventManager_Protected_get_EventManager_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaDescription_Protected_get_TextMeshProUGUI_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_SetExp_Protected_Void_Int32_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
