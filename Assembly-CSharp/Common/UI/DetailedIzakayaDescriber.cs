using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using TMPro;

namespace Common.UI
{
	// Token: 0x0200036F RID: 879
	public class DetailedIzakayaDescriber : SelectedIzakayaDescriber
	{
		// Token: 0x06006879 RID: 26745 RVA: 0x001FB28C File Offset: 0x001F948C
		// Note: this type is marked as 'beforefieldinit'.
		static DetailedIzakayaDescriber()
		{
			Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DetailedIzakayaDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr);
			DetailedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr, "m_IzakayaDescription");
			DetailedIzakayaDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr, 100685052);
			DetailedIzakayaDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Void_Izakaya_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr, 100685053);
			DetailedIzakayaDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr, 100685054);
			DetailedIzakayaDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr, 100685055);
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x001FB320 File Offset: 0x001F9520
		public unsafe override int Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedIzakayaDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001FB368 File Offset: 0x001F9568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267798, XrefRangeEnd = 267802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Describe(Izakaya data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedIzakayaDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_Void_Izakaya_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001FB3CC File Offset: 0x001F95CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267802, XrefRangeEnd = 267804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedIzakayaDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x001FB408 File Offset: 0x001F9608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267804, XrefRangeEnd = 267805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetailedIzakayaDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetailedIzakayaDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedIzakayaDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x000387B5 File Offset: 0x000369B5
		public DetailedIzakayaDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x001FB444 File Offset: 0x001F9644
		// (set) Token: 0x06006880 RID: 26752 RVA: 0x000387BE File Offset: 0x000369BE
		public unsafe TextMeshProUGUI m_IzakayaDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetailedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetailedIzakayaDescriber.NativeFieldInfoPtr_m_IzakayaDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004546 RID: 17734
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaDescription;

		// Token: 0x04004547 RID: 17735
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0;

		// Token: 0x04004548 RID: 17736
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Void_Izakaya_CancellationToken_0;

		// Token: 0x04004549 RID: 17737
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400454A RID: 17738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
