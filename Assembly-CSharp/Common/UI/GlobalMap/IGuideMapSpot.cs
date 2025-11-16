using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.UI.GlobalMap
{
	// Token: 0x020003D3 RID: 979
	public class IGuideMapSpot : Il2CppObjectBase
	{
		// Token: 0x060074E6 RID: 29926 RVA: 0x00223F98 File Offset: 0x00222198
		// Note: this type is marked as 'beforefieldinit'.
		static IGuideMapSpot()
		{
			Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GlobalMap", "IGuideMapSpot");
			IGuideMapSpot.NativeMethodInfoPtr_get_PrimaryName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr, 100687307);
			IGuideMapSpot.NativeMethodInfoPtr_get_UIButton_Public_Abstract_Virtual_New_get_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr, 100687308);
			IGuideMapSpot.NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr, 100687309);
			IGuideMapSpot.NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr, 100687310);
			IGuideMapSpot.NativeMethodInfoPtr_get_IsActivated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGuideMapSpot>.NativeClassPtr, 100687311);
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x00224024 File Offset: 0x00222224
		public unsafe virtual string PrimaryName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGuideMapSpot.NativeMethodInfoPtr_get_PrimaryName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x060074E8 RID: 29928 RVA: 0x00224068 File Offset: 0x00222268
		public unsafe virtual UIButtonSimple UIButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGuideMapSpot.NativeMethodInfoPtr_get_UIButton_Public_Abstract_Virtual_New_get_UIButtonSimple_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr3) : null;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x002240B4 File Offset: 0x002222B4
		public unsafe virtual RectTransform RectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGuideMapSpot.NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00224100 File Offset: 0x00222300
		[CallerCount(0)]
		public unsafe virtual bool MatchesMapNameOrSubset(string mapName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGuideMapSpot.NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x00224158 File Offset: 0x00222358
		public unsafe virtual bool IsActivated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGuideMapSpot.NativeMethodInfoPtr_get_IsActivated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x0003F4A1 File Offset: 0x0003D6A1
		public IGuideMapSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004D71 RID: 19825
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04004D72 RID: 19826
		private static readonly IntPtr NativeMethodInfoPtr_get_UIButton_Public_Abstract_Virtual_New_get_UIButtonSimple_0;

		// Token: 0x04004D73 RID: 19827
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;

		// Token: 0x04004D74 RID: 19828
		private static readonly IntPtr NativeMethodInfoPtr_MatchesMapNameOrSubset_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04004D75 RID: 19829
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
