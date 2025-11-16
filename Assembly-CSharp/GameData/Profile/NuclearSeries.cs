using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Profile
{
	// Token: 0x02000304 RID: 772
	public class NuclearSeries : CookerAssetBase
	{
		// Token: 0x06005CD9 RID: 23769 RVA: 0x001D353C File Offset: 0x001D173C
		// Note: this type is marked as 'beforefieldinit'.
		static NuclearSeries()
		{
			Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NuclearSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr);
			NuclearSeries.NativeFieldInfoPtr_failProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr, "failProbability");
			NuclearSeries.NativeFieldInfoPtr_qteSucceededfailProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr, "qteSucceededfailProbability");
			NuclearSeries.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr, 100682462);
			NuclearSeries.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr, 100682463);
			NuclearSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr, 100682464);
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x001D35D0 File Offset: 0x001D17D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232709, XrefRangeEnd = 232721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearSeries.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x001D3624 File Offset: 0x001D1824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232721, XrefRangeEnd = 232724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedFood);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref couldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NuclearSeries.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x001D369C File Offset: 0x001D189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232724, XrefRangeEnd = 232725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NuclearSeries() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NuclearSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NuclearSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x00032B5B File Offset: 0x00030D5B
		public NuclearSeries(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x001D36D8 File Offset: 0x001D18D8
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x00032B64 File Offset: 0x00030D64
		public unsafe float failProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearSeries.NativeFieldInfoPtr_failProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearSeries.NativeFieldInfoPtr_failProbability)) = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001D3700 File Offset: 0x001D1900
		// (set) Token: 0x06005CE1 RID: 23777 RVA: 0x00032B7F File Offset: 0x00030D7F
		public unsafe float qteSucceededfailProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearSeries.NativeFieldInfoPtr_qteSucceededfailProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NuclearSeries.NativeFieldInfoPtr_qteSucceededfailProbability)) = value;
			}
		}

		// Token: 0x04003D7C RID: 15740
		private static readonly IntPtr NativeFieldInfoPtr_failProbability;

		// Token: 0x04003D7D RID: 15741
		private static readonly IntPtr NativeFieldInfoPtr_qteSucceededfailProbability;

		// Token: 0x04003D7E RID: 15742
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D7F RID: 15743
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0;

		// Token: 0x04003D80 RID: 15744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
